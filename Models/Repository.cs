namespace MeetingApp.Models{
    public static class Repository{
        private static List<UserInfo> _users=new();

        static Repository(){
            _users = new List<UserInfo>(){
                new UserInfo(){ID=1,Name="Murat Ateş",Phone="0553 456 7890",Email="muratates@gmail.com",WillAttend=true},
                new UserInfo(){ID=2,Name="Hakan Duman",Phone="0531 185 9924",Email="dumanhakan01@gmail.com",WillAttend=false},
                new UserInfo(){ID=3,Name="Zeynep Sak",Phone="0533 179 0032",Email="zeynepsakk34@gmail.com",WillAttend=false},
                new UserInfo(){ID=4,Name="Diyar Solak",Phone="0546 845 2402",Email="dyrsolak@gmail.com",WillAttend=true},
                new UserInfo(){ID=5,Name="Ayşe Kahya",Phone="0550 671 5568",Email="aysekahya36@gmail.com",WillAttend=true},
            };
        }

        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            if(!_users.Any(u => u.Email == user.Email)){
                user.ID=_users.Count()+1;
                _users.Add(user);
            }
            return;
        }
        public static UserInfo? GetById (int? id){
            return _users.FirstOrDefault(user=>user.ID==id);
        }
    }
}