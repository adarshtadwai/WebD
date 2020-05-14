using System;

public class Product
{
	public Product()
    {

    }

	public Product(int productId)
    {
		ProductId = productId;
    }

	public string ProductName { get; set; }
	public string Discription { get; set; }
	public double CurrentPrice { get; set; }
    public string  ProductId { get; private set; }

	public Product Retrieve()
    {
        return new Product();
    }

    public bool Save()
    {
        //code that saves the order
        return true;
    }

    bool Validate()
    {
        return string.IsNullOrWhiteSpace(ProductName) || Currentprice;
    }



}
