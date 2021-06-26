using System.IO;
namespace LearnInpAndOut
{
    public class Item
    {
        public string NameItem { get; set; }
        public int OnHand { get; set; }
        public double Cost { get; set; }

        public Item(string nameItem, int onHand, double cost)
        {
           Init(nameItem,onHand,cost);
        }

        public Item() : this(" ", 0, 0.0)
        {}

        public void Init(string nameItem, int onHand, double cost)
        {
            NameItem = nameItem;
            OnHand = onHand;
            Cost = cost;
        }
        public void RecordInBinaryFile(BinaryWriter bw)
        {
            bw.Write(NameItem);
            bw.Write(OnHand);
            bw.Write(Cost);
        }

        public static Item LoadFromBinaryFile(BinaryReader br)
        {
            Item someItem = new Item {NameItem = br.ReadString(), OnHand = br.ReadInt32(), Cost = br.ReadDouble()};
            return someItem;
        }

        public override string ToString()
        {
            return "Name: " + NameItem + "\non Hand: " + OnHand + "\ncost:"
                   + Cost + "\nAll cost:" + OnHand * Cost;
        }
        
    }
}
