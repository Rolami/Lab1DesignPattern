using System;

namespace Lab1DesignPattern
{
    public class TravelCenterFactory
    {
        private static TravelCenterFactory? _instance; // SÅ HÄR ÄR DET. Deklarering

        private TravelCenterFactory() { }
        //tom constructor som används internt för att förhindra public contructor.


        //Singleton
        public static TravelCenterFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TravelCenterFactory();
                //Om ingen fanns, finns den nu. 
            }
            return _instance;
        }

        public ITravelCenter CreateTravelCenter(){
            
            throw new NotImplementedException();
        }



    }
}

