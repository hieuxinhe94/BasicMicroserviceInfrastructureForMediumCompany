import { Injectable } from '@angular/core';
import { ProductCategory } from '../model/product-category';
import { BehaviorSubject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { AppConstants } from '../model/appConstants';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

 // Declare object store datas
 topCategoies: ProductCategory[];
 categories: ProductCategory[];
 highlight: ProductCategory[]; 

 // declare state objects
 public isReady = new BehaviorSubject<boolean>(false);

 constructor(private http: HttpClient) {
 }

 // state of data
 getIsReady(type: string) {
   this.isReady.next(false);
   switch (type) {
     case 'all': {
       if (this.categories) this.isReady.next(true); break;
     }
     case 'top': {
       if (this.topCategoies) this.isReady.next(true); break;
     }
     case 'highlight': {
       if (this.highlight) this.isReady.next(true); break;
     }
   }
   return this.isReady.asObservable();
 }

 setIsReady(value: boolean) {
   this.isReady.next(value);
 }

 // Get and set
 getSections(type: string) {
   switch (type) {
     case 'all': {
       return (this.categories);
     }
     case 'top': {
       return (this.topCategoies);
     }
     case 'highlight': {
       return (this.highlight);
     }
   }
   return [];
 }

 setProducts(type: string, data: ProductCategory[]) {
   switch (type) {
     case 'all': {
      this.categories = data;
      this.topCategoies = data.slice(0, 3);
      this.highlight = data.slice(0, 3);
      break;
     }
     case 'top': {
       this.topCategoies = data;
       break;
     }
     case 'highlight': {
       this.highlight = data;
       break;
     }
   }
   this.setIsReady(true);
 }
   
 // Http methods
 getAll() {
   return this.http.get<ProductCategory[]>(AppConstants.ApiEndpoint + 'api/ProductCategory');
 }

 getBySection(type: string) {
   return this.http.get<ProductCategory[]>(AppConstants.ApiEndpoint + 'api/ProductCategory/GetBySection?section=' + type);
 }

 getByCategory(id: number) {
   return this.http.get<ProductCategory[]>(AppConstants.ApiEndpoint + 'api/Product/GetByCategory?id=' + id);
 }

 getById(id: number) {
   return this.http.get<ProductCategory>(AppConstants.ApiEndpoint + 'api/Product/GetById?id=' + id);
 }
}