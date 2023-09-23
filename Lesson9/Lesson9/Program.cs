using System.Text.Json;

Barn barn = new Barn();

barn.AddProduct(new Product
{
    Name = "Milk",
    ProductionDate = DateTime.Parse("2023-09-15"),
    ExpiresOn = DateTime.Parse("2023-09-30"),
    BruttoWeight = 1000,
    NettoWeight = 950
});

barn.AddProduct(new Product
{
    Name = "Bread",
    ProductionDate = DateTime.Parse("2023-09-14"),
    ExpiresOn = DateTime.Parse("2023-09-18"),
    BruttoWeight = 500,
    NettoWeight = 450
});

barn.SaveToJson("products.json");


barn.LoadFromJson("products.json");

foreach (var product in barn.Products)
{
    Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Production Date: {product.ProductionDate}, Expires On: {product.ExpiresOn}, Brutto Weight: {product.BruttoWeight}, Netto Weight: {product.NettoWeight}");
}



public class Barn
{
    private List<Product> products;

    public Barn()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        product.ID = GenerateID();
        products.Add(product);
    }

    public void EditProduct(int id, Product updatedProduct)
    {
        Product existingProduct = products.Find(p => p.ID == id);
        if (existingProduct != null)
        {
            existingProduct.Name = updatedProduct.Name;
            existingProduct.ProductionDate = updatedProduct.ProductionDate;
            existingProduct.ExpiresOn = updatedProduct.ExpiresOn;
            existingProduct.BruttoWeight = updatedProduct.BruttoWeight;
            existingProduct.NettoWeight = updatedProduct.NettoWeight;
        }
    }

    public void DeleteProduct(int id)
    {
        Product productToRemove = products.Find(p => p.ID == id);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
        }
    }

    public void SaveToJson(string filename)
    {
        string json = JsonSerializer.Serialize(products, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText(filename, json);
    }

    public void LoadFromJson(string filename)
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            products = JsonSerializer.Deserialize<List<Product>>(json);
        }
    }

    private int GenerateID()
    {
        
        return (int)DateTime.Now.Ticks;
    }

    public IReadOnlyList<Product> Products => products.AsReadOnly();
}

