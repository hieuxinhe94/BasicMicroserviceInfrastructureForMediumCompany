import { ProductCategory } from "./product-category";
import { ProductModel } from "./product-model";
import { ProductViewType } from "./product-view-type";
import { OrderDetail } from "./order-detail";

export class Product {
    id: number;
    productName: string;
    productprice: Number;
    productDiscount: Number;
    productCostReference: Number;
    productReference: string;
    productWeight: number;
    
    productTags: string;
    productShortDesc: string;
    productLongDesc: string;
    productThumb: string;
    productAvatar: string;
    productCategoryId: number;
    productUpdateDate: Date;
    productCount: number;
    productModelId: number;
    productLocation: string;
    productIssurance: number;
    productIssuranceDesc: string;
    productIsAvailable: boolean;
    productIsDeleted: boolean;
    productDateCreated: Date;
    productViewTypeId: number;
    rating: number;
    productCategory : ProductCategory;
    productModel: ProductModel;
    productViewType : ProductViewType;
    orderDetails: OrderDetail[];

    /**
     *
     */
    constructor() {
      
    }
}
