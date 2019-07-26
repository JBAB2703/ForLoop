using System;

namespace ForLoopProject {
    class Customer {
        public string Name { get; set; }
        public string State { get; set; }
    }
    class Program {
        static void Main(string[] args) {

            Customer[] customers = {
                new Customer {Name = "PG", State = "OH"},
                new Customer {Name = "SDCust", State = "SD"},
                new Customer {Name = "MTCust", State = "MT"},

            };

            bool FoundSDCust = false;
            bool FoundMTCust = false;

            foreach(Customer cust in customers) {


                switch(cust.State) {
                    case "MT":
                        FoundMTCust = true;
                        break;
                    case "SD":
                        FoundMTCust = true;
                        break;
                }

            ////    if(cust.State == "MT") {
            ////        FoundMTCust = true;
            ////        continue;
            ////    }
                

            ////    if(cust.State == "SD") {
            ////        FoundSDCust = true;
            ////        continue;
            ////    }

            ////    if(FoundMTCust && FoundSDCust) {
            ////        break;
            //    }
            }

            Console.WriteLine($"Found MT Customer: {FoundMTCust}");
            Console.WriteLine($"Found SD Customer: {FoundSDCust}");












            int[] ints = { 89, 188, 295, 943, 975, 277, 119, 736, 952, 321, 521, 444, 758, 397, 915, 878, 674, 701, 379, 331, 804, 461, 459, 908, 373 };

            string[] names = { "Brailee", "Braina", "Marianne", "Alex", " Maggie", "Titus", "Jesse" };

            string First = ""; 

            foreach(string FirstName in names){

                string upperName = FirstName.ToUpper();
                First += upperName;
            }

            Console.WriteLine(First);

            int total = 0;

            foreach(int anInt in ints){
                total += anInt;
            }

           // for(int idx = 0; idx < ints.Length; idx++) { total += ints[idx] * 1 / 2; }

            decimal average = total / (decimal) ints.Length;
                                        // (decimal) is called a CAST. 

            Console.WriteLine($"Total: {total}, Average: {average}");

        }
    }
}

