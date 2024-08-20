using Dapper;
using KancelAPI.Context.Interface;
using KancelAPI.Interfaces.Repository.Administration;
using KancelAPI.Models.Administration;

namespace KancelAPI.Repository.Administration
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public ApplicationUserRepository(IConfiguration configuration, IDbConnectionFactory dbConnectionFactory)
        {
            _configuration = configuration;
            _dbConnectionFactory = dbConnectionFactory;
        }

        public async Task<bool> Add(ApplicationUser obj)
        {
            using (var db = _dbConnectionFactory.CreateConnection())
            {
                var sql = $@"INSERT INTO 
                                ApplicationUser (
                                    ApplicationUserId, 
                                    FirstName, 
                                    LastName, 
                                    Email, 
                                    Password, 
                                    Field)
                             VALUES (
                                    '{obj.ApplicationUserId}', 
                                    '{obj.FirstName}', 
                                    '{obj.LastName}', 
                                    '{obj.Email}', 
                                    '{obj.Password}', 
                                    {obj.Field});";

                var r = await db.QueryFirstOrDefaultAsync<bool>(sql);

                return r;
            }
        }

        public async Task<ApplicationUser> Login(string email, string password)
        {
            using (var db = _dbConnectionFactory.CreateConnection())
            {
                var sql = $@"
                        SELECT 
                            Password 
                        FROM 
                            ApplicationUser 
                        WHERE 
                            Email = '{email}'";

                var storedPassword = await db.QueryFirstOrDefaultAsync<string>(sql);

                if (storedPassword != null && storedPassword == password)
                {
                    sql = $@"SELECT 
                                *
                             FROM 
                                ApplicationUser
                              WHERE 
                                Email = '{email}'";

                    var r = await db.QueryFirstOrDefaultAsync<ApplicationUser>(sql);
                    return r;
                }

                return null;
            }
        }

        public async Task<bool> UpdatePassword(Guid applicationUserId, string newPassword, string lastPassword)
        {
            using (var db = _dbConnectionFactory.CreateConnection())
            {
                var sqlCheck = $@"SELECT 
                                    Password 
                                  FROM 
                                    ApplicationUser 
                                  WHERE 
                                    ApplicationUserId = '{applicationUserId}'";

                var currentPassword = await db.QueryFirstOrDefaultAsync<string>(sqlCheck);

                if (currentPassword == lastPassword) 
                {
                    var sqlUpdate = $@"
                                      UPDATE 
                                        ApplicationUser
                                      SET 
                                        Password = '{newPassword.Replace("'", "''")}'
                                      WHERE 
                                        ApplicationUserId = '{applicationUserId}'";

                    int rowsAffected = await db.ExecuteAsync(sqlUpdate);
                    return rowsAffected > 0;
                }

                return false;
            }
        }
    }
}
