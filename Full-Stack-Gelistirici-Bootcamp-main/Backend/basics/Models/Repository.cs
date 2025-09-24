namespace basics.Models
{

    public class Repository
    {
        private static readonly List<Bootcamp> _bootcamps = new List<Bootcamp>();

        static Repository()
        {
            _bootcamps = new List<Bootcamp>()
            {
                new Bootcamp() {id = 1, Title = "aspnet bootcamps", Description = "başladık", Image = "1.png",isActive = false,isHome = true},
                new Bootcamp() {id = 2, Title = "java bootcamps", Description = "başladık", Image = "2.png",isActive = true,isHome = true},
                new Bootcamp() {id = 3, Title = "unity bootcamps", Description = "başladık", Image = "3.png",isActive = true,isHome = false},
            };
        }

        public static List<Bootcamp> Bootcamps
        {
            get { return _bootcamps; }
        }

        public static Bootcamp? GetById(int? id)
        {
            return _bootcamps.FirstOrDefault(b=>b.id == id);
        }
    }
}