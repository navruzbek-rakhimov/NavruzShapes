select p.ProductName, pc.CategoryName
from Products p left join 
    (select c.CategoryName, pc.CategoryId, pc.ProductId 
    from Categories c 
    inner join ProductCategories pc 
    on c.CategoryId = pc.CategoryId) pc
on p.ProductId = pc.ProductId
