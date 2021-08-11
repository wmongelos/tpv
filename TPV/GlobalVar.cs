using System;

namespace TPV
{
    public static class GlobalVar
    {
        public static Boolean isTrial;
        public static Int32 CurrentUser_Id;
        public static Int32 CurrentUser_Rol_Id;
        public static String CurrentUser_Name;
        public static Tipo_Software Tipo_Soft;

        public enum Tipo_Software
        {
            TPV = 1,
            RESTO = 2,
            HELADERIA = 3
        }

        
    }
}
