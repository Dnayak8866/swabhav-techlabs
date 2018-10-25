import { Http} from '@angular/http';
import{Injectable, Inject} from '@angular/core';

@Injectable()
export class ProductDataService {

   

    constructor(private _http:Http) {
       

      //  this.initProductList();
    }

    GetAllProducts() {
        return this._http.get("http://localhost:54139/api/Acme/Allproducts").toPromise();
    }

    // getProductById(id: number) {
       
    //     for (let product of this.pruductlist) {
    //         if (product.productId == id) {
    //             return product;

    //         }
    //     }
      
    // }

    // getProductById(id:number){
    //     return new Promise((resolve,reject)=>{
    //         for(let product of this.pruductlist){
    //             if(product.productId==id){
    //                 resolve(product);
    //                 return;
    //             }
    //         }
    //         reject(false);
    //     });
    // }

    getProductById(id:number){
        return this._http.get("http://localhost:54139/api/Acme/product/"+id).toPromise();
    }



    // searchProduct(filterValue: string){

    //     let matchingList: any[];
    //     matchingList = [];

    //     for (let p of this.pruductlist) {
    //         if (p.productName.includes(filterValue)) {
    //             matchingList.push(p);
    //         }
    //     }
    //     return matchingList;
    // }

    searchProduct(filterValue: string){
        return this._http.get("http://localhost:54139/api/Acme/product/"+filterValue).toPromise();
    }

}