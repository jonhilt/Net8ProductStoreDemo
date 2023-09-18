using ProductStore.Components.Pages;

namespace ProductStore.Data;

public class ProductData
{
    List<ProductListItem> products = new()
    {
        new()
        {
            Name = "Blue Jeans", ShortDescription = "On-Trend since 1952!",
            ImageUrl = "https://source.unsplash.com/5C3A7b9Wc30"
        },
        new()
        {
            Name = "T-Shirt", ShortDescription = "Fashionable women's t-shirt",
            ImageUrl = "https://source.unsplash.com/fEt6Wd4t4j0"
        },
        new()
        {
            Name = "PS5", ShortDescription = "Finally, in stock!", 
            ImageUrl = "https://source.unsplash.com/NVD_32BBZFE"
        },
    };

    public async Task<IEnumerable<ProductListItem>> List(string searchTerm)
    {
        return string.IsNullOrEmpty(searchTerm)
            ? products
            : products.Where(x =>
                x.ShortDescription.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                || x.Name.Contains(searchTerm, StringComparison.CurrentCultureIgnoreCase));
    }
}