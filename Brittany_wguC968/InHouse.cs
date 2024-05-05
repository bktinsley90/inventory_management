namespace Brittany_wguC968
{
    public class InHouse : Part
    {
        private int machineID;
        public int Machine { get; set; }
        public InHouse() { }
        public InHouse(int partID, string name, int instock, decimal price, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = instock;
            Price = price;
            Max = max;
            Min = min;
            Machine = machineID;

        }
   
    }
}