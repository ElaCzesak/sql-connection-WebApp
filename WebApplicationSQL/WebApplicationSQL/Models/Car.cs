namespace WebApplicationSQL.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
