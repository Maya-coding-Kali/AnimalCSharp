using System;

namespace Animal
{
    public class Frog
    {
        private String Name;
        private String Color;
        public Frog()
        {
            Name = "DefaultFrog";
            Color = "Green";
        }
        public Frog(String VName, String VColor)
        {
            Name = VName;
            Color = VColor;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetName(String VName)
        {
            Name = VName;
        }
        public void SetColor(String VColor)
        {
            Color = VColor;
        }
        public String Sounds()
        {
            return "Ribbit";
        }





        public class Cat
        {
           private String Name;
           private String Color;
           private String Age;
             

            public Cat(String VName, String VColor)
            {
                Name = VName;
                Color = VColor;
            }
            public string GetName()
            {
                return Name;
            }
            public string GetColor()
            {
                return Color;
            }
            public void SetName(String VName)
            {
                Name = VName;
            }
            public void SetColor(String VColor)
            {
                Color = VColor;
            }
            public void SetAge(String VName)
            {
              
            }
            public void Set(String VColor)
            {
                Color = VColor;
            }
            public String Sounds()
            {
                return "Ribbit";
            }

        }
    }
}
