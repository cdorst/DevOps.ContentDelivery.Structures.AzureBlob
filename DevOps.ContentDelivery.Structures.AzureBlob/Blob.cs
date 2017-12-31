namespace DevOps.ContentDelivery.Structures.AzureBlob
{
    public struct Blob
    {
        public Blob(string container, string name)
        {
            Container = container;
            Name = name;
        }

        public string Container { get; set; }
        public string Name { get; set; }
    }
}
