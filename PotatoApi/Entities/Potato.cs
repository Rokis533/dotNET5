namespace PotatoApi.Entities
{
    public class Potato
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public string FilePath { get; set; } //arba šitas
        public byte[] Bytes { get; set; } //arba šitas
    }
}
