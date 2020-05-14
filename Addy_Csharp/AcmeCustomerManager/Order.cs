using System;

public class Order
{
	public Order()
	{

	}
	public Order(int orderId)
    {
		orderId = orderId;
    }

	public DateTimeOffset? OrderDate { get; set; }
	public int OrderId { get; private set; }

	public Order Retrieve(int orderId)
    {
		return new Order();
    }

	public bool Retrive()
    {
		//code that saves the order
		return new Order();
    }

	public bool Save()
    {
		//code that saves the defined order.
		return true;
    }

	public bool Validate()
    {
		return OrderDate;
    }


}
