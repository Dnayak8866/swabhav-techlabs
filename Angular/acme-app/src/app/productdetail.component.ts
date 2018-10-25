import { Component } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { ProductDataService } from "./Services/ProductDataService";

@Component({ templateUrl: "./productdetail.component.html" })
export class ProductDetail {

    productname: string;
    productid: number;
    product: any = {};
   

    constructor(private _routes: ActivatedRoute, private _productDataService: ProductDataService,private _router:Router) {
        this._routes.params.subscribe(params => {
            
            this.productid = params.pid;
            this._productDataService.getProductById(this.productid)
                .then((resolve)=>this.product=resolve.json())
                .catch((reject)=>console.log("error while getting product"));
            this.productname = this.product.ProductName;
          
            
        });
        console.log(this.productname);
        console.log(this.productid);
    }

    goBack(){
        this._router.navigate(['ProductList']);
    }
    
}