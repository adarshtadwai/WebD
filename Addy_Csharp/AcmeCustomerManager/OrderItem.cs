using System;

public class OrderItem
{
	public OrderItem()
	{

	}
	public OrderItem(int orderItemId)
    {
		OrderItemId = orderItemId;
    }

	public int OrderItemId { get; private set; }
	public int ProductId { get; set; }
	public decimal? PurchasePrice { get; set; }
	public int Quantity { get; set; }

	public bool Retrive()
	{
		//code that saves the order
		return OrderItem();
	}

	public bool Save()
	{
		//code that saves the defined order.
		return true;
	}

	public bool Validate()
	{
		return Quantity>0 && ProductId>0 && PurchasePrice != null;
	}
}
