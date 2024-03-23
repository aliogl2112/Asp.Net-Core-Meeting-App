namespace MeetingApp.Models{
    public static class Repository{
        private static List<UserInfo> _users=new();

        static Repository(){
            _users = new List<UserInfo>(){
                new UserInfo(){Name="Murat Ateş",Phone="0553 456 7890",Email="muratates@gmail.com",WillAttend=true},
                new UserInfo(){Name="Hakan Duman",Phone="0531 185 9924",Email="dumanhakan01@gmail.com",WillAttend=false},
                new UserInfo(){Name="Zeynep Sak",Phone="0533 179 0032",Email="zeynepsakk34@gmail.com",WillAttend=false},
                new UserInfo(){Name="Diyar Solak",Phone="0546 845 2402",Email="dyrsolak@gmail.com",WillAttend=true},
                new UserInfo(){Name="Ayşe Kahya",Phone="0550 671 5568",Email="aysekahya36@gmail.com",WillAttend=true},
            };
        }

        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            if(!_users.Any(u => u.Email == user.Email)){
                _users.Add(user);
            }
            return;
        }
    }
}