using System;

namespace Lab13
{
    // This is the Class For dog
    class building
    {
        private int stories;
        private int apartments;
        private float occupancy;
        private bool isoccupied;

        // Constructor 
        public building()
        {
            stories = 10;
            apartments = 20;
            occupancy = 1f;
            isoccupied = true;
        }

        // Setters
        public void setStories(int setStories)
        {
            stories = setStories;
        }

        public void setApartments(int setApartments)
        {
            apartments = setApartments;
        }

        public void setOccupancy(float setOccupancy)
        {
            occupancy = setOccupancy;
        }

        public void setIsOccupied(bool setIsOccupied)
        {
            isoccupied = setIsOccupied;
        }

        // Getters 

        public int getStories()
        {
            return stories;
        }

        public int getapartments()
        {
            return apartments;
        }

        public float getOccupancy()
        {
            return occupancy;
        }

        public bool getIsOccupied()
        {
            return isoccupied;
        }

    }

    class Lab12
    {
        static void Main(string[] args)
        {
            building buildingOne = new building();
            building buildingTwo = new building();

            Console.Write("Year 2020:\n");
            Console.Write("Building 1 has ");
            Console.Write(buildingOne.getStories() + " floors, " + buildingOne.getapartments());
            Console.Write(" apartments, and is " + (buildingOne.getOccupancy() * 100) + "% occupied. Full? ");

            if (buildingOne.getIsOccupied() == true)
                Console.Write("true");
            else
                Console.Write("false");

            buildingTwo.setStories(30);
            buildingTwo.setApartments(30);
            buildingTwo.setOccupancy(.75f);
            buildingTwo.setIsOccupied(false);

            Console.Write("\n");
            Console.Write("Building 2 has ");
            Console.Write(buildingTwo.getStories() + " floors, " + buildingTwo.getapartments());
            Console.Write(" apartments, and is " + (buildingTwo.getOccupancy() * 100) + "% occupied. Full? ");

            if (buildingTwo.getIsOccupied() == true)
                Console.Write("true");
            else
                Console.Write("false");

            Console.WriteLine("\n\nMany years pass.\n");

            buildingOne.setOccupancy(0f);
            buildingOne.setIsOccupied(false);

            buildingTwo.setOccupancy(1f);
            buildingTwo.setIsOccupied(true);

            Console.Write("Year 2043:\n");
            Console.Write("Building 1 has ");
            Console.Write(buildingOne.getStories() + " floors, " + buildingOne.getapartments());
            Console.Write(" apartments, and is " + (buildingOne.getOccupancy() * 100) + "% occupied. Full? ");

            if (buildingOne.getIsOccupied() == true)
                Console.Write("true");
            else
                Console.Write("false");

            Console.Write("\n");
            Console.Write("Building 2 has ");
            Console.Write(buildingTwo.getStories() + " floors, " + buildingTwo.getapartments());
            Console.Write(" apartments, and is " + (buildingTwo.getOccupancy() * 100) + "% occupied. Full? ");

            if (buildingTwo.getIsOccupied() == true)
                Console.Write("true");
            else
                Console.Write("false");

            Console.WriteLine("\n\nLooks like people prefer taller buildings.");


        }
    }
}
