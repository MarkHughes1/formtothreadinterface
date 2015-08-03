namespace EngineClass
{
    public static class Conversions
    {
        /// <summary>
        /// Convert cubic centimeters to cubic inches
        /// </summary>
        /// <param name="cc"></param>
        /// <returns></returns>
        public static double CcToCuIn(double cc)
        {
            double cuin = cc / 16.387064;

            return cuin;
        }

        /// <summary>
        /// Convert cubic inches to cubic centimeters
        /// </summary>
        /// <param name="cuin"></param>
        /// <returns></returns>
        public static double CuInToCc(double cuin)
        {
            double cc = cuin / 0.0610237441;

            return cc;
        }
    }
}
