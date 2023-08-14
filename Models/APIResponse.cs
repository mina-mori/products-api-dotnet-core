namespace ProductsAPI
{
    public class APIResponse
    {
        public bool success { get; set; }
        public object results { get; set; }
        public string[] messages { get; set; }
    }
}
