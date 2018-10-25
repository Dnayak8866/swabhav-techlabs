import { Component } from "@angular/core";
import { ProductDataService } from "./Services/ProductDataService";

@Component({templateUrl:"./productlist.component.html"})
export class ProductListComponent{

    isHide=true;
    btnText="Show Image";
    filterby:string;
    isHideFilterHeading=true;

    productList:any[];
    constructor(private _productDataService:ProductDataService){
   
           // this.productList = this._productDataService.pruductlist;
            this._productDataService.GetAllProducts()
                .then((r)=>this.productList=r.json())
                .catch((e)=>console.log("cannot fetch products from server.."));
 
        console.log(this.productList);
    }

    toggleImage(){
        if(this.isHide){
            this.isHide=false;
            this.btnText="Hide Image";
            return;
        }
        this.isHide=true;
        this.btnText="Show Image";
        
    }

    SeacrhProducts(e){
        this.filterby=e;
        this.isHideFilterHeading=false;
        console.log("Filter text:",this.filterby);
        if(this.filterby==""){
            console.log(" Search Box is Empty..");
            this.isHideFilterHeading=true;
            //this.productList =this. _productDataService.pruductlist;
            this._productDataService.GetAllProducts()
            .then((response)=>this.productList=response.json())
            .catch((e)=>console.log("cannot fetch products..."));
            return;
        }
   //    this.productList = this._productDataService.searchProduct(this.filterby);
       this._productDataService.searchProduct(this.filterby)
       .then((response)=>this.productList=response.json())
       .catch((e)=>console.log("error while getting products..."));
       console.log(this.productList);
    }

}