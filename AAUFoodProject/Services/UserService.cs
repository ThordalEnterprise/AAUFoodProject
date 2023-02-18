using System;
using System.Threading.Tasks;
using Firebase.Database;
using AAUFoodProject.Model;
using System.Linq;
using Firebase.Database.Query;
using Xamarin.Forms;
using AAUFoodProject.Services;

[assembly:Dependency(typeof(UserService))]
namespace AAUFoodProject.Services
{
    public class UserService 
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://aaudelevery.firebaseio.com/");
        }

        public async Task<bool> IsUserExists(string uname)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> RegisterUser(string uname, string passwd)
        {
            if( await IsUserExists(uname) == false)
            {
                await client.Child("Users")
                    .PostAsync(new User()
                    {
                        Username = uname,
                        Password = passwd
                    });
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> LoginUser(string uname, string passwd)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == uname)
                .Where(u => u.Object.Password == passwd).FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> LoginStaffUser(string uname, string passwd)
        {
            var Staffuser = (await client.Child("StaffUsers")
                .OnceAsync<StaffUser>()).Where(u => u.Object.StaffUsername == uname)
                .Where(u => u.Object.StaffPassword == passwd).FirstOrDefault();

            return (Staffuser != null);
        }

        public async Task<bool> LoginAdminUser(string uname, string passwd)
        {
            var Aminuser = (await client.Child("AdminUsers")
                .OnceAsync<AdminUserModel>()).Where(u => u.Object.AdminUsername == uname)
                .Where(u => u.Object.AdminPassword == passwd).FirstOrDefault();

            return (Aminuser != null);
        }
    }
}
