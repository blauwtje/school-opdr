class ShoppingCart
{
    public List<GroupedShopItem> Groceries;
    public ShoppingCart()
    {
        Groceries = new List<GroupedShopItem>();
    }
    public void AddItem(ShopItem item)
    {
        GroupedShopItem existingItem = FindItem(item);
        if (existingItem != null)
        {
            existingItem.Quantity++;
        }
        else
        {
            GroupedShopItem groupedItem = new GroupedShopItem(item);
            Groceries.Add(groupedItem);
        }
    }
    public GroupedShopItem FindItem(ShopItem item)
    {
        foreach (GroupedShopItem groupedItem in Groceries)
        {
            if (groupedItem.Item.ID == item.ID)
            {
                return groupedItem;
            }
        }
        return null!;
    }
    public string Contents()
    {
        string contents = "";
        foreach (GroupedShopItem groupedItem in Groceries)
        {
            contents += $"{groupedItem.Item.Name} x {groupedItem.Quantity}\n";
        }
        return contents;
    }
    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach (GroupedShopItem groupedItem in Groceries)
        {
            totalPrice += groupedItem.Item.Price * groupedItem.Quantity;
        }
        return totalPrice;
    }
}