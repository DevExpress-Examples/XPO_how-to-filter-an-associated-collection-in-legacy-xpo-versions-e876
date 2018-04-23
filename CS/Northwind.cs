using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Northwind {

    [Persistent("Categories")]
    public class Category : XPLiteObject {
        public Category(Session session) : base(session) { }

        [Key(true), Persistent("CategoryID")]
        int fCategoryID = -1;
        
        [PersistentAlias("fCategoryID")]
        public int CategoryID {
            get { return fCategoryID; }
        }
        string fCategoryName;
        public string CategoryName {
            get { return fCategoryName; }
            set { SetPropertyValue<string>("CategoryName", ref fCategoryName, value); }
        }
        string fDescription;
        public string Description {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }

        [Association("ProductCategories")]
        public XPCollection<Product> Products {
            get { return GetCollection<Product>("Products"); }
        }

        // a filtered collection
        public XPCollection<Product> AvailableProducts {
            get {
                CriteriaOperator filter = new OperandProperty("Discontinued") != new OperandValue(true);
                return new XPCollection<Product>(this.Products, filter); 
            }
        }
    }

    [Persistent("Products")]
    public class Product : XPLiteObject {
        public Product(Session session) : base(session) { }

        [Key(true), Persistent("ProductID")]
        int fProductID = -1;
        
        [PersistentAlias("fProductID")]
        public int ProductID {
            get { return fProductID; }
        }

        string fProductName;
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue<string>("ProductName", ref fProductName, value); }
        }
        
        Category fCategory;
        [Persistent("CategoryID"), Association("ProductCategories")]
        public Category Category {
            get { return fCategory; }
            set { SetPropertyValue<Category>("Category", ref fCategory, value); }
        }

        decimal fUnitPrice;
        public decimal UnitPrice {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref fUnitPrice, value); }
        }
        bool fDiscontinued;
        public bool Discontinued {
            get { return fDiscontinued; }
            set { SetPropertyValue<bool>("Discontinued", ref fDiscontinued, value); }
        }
    }

}
