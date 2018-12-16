import { Injectable } from '@angular/core';
import { Product } from '../model/product';
import { BehaviorSubject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { AppConstants } from '../model/appConstants';
import { Searchview } from '../model/searchview';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  // Declare object store datas
  hotdealProducts: Product[];
  newProducts: Product[];
  suggestingProducts: Product[];
  allProducts: Product[];

  // declare state objects
  public isReady = new BehaviorSubject<boolean>(false);

  constructor(private http: HttpClient) {
  }

  // state of data
  getIsReady(type: string) {
    this.isReady.next(false);
    switch (type) {
      case 'all': {
        if (this.allProducts) this.isReady.next(true); break;
      }
      case 'hotdeal': {
        if (this.hotdealProducts) this.isReady.next(true); break;
      }
      case 'new': {
        if (this.newProducts) this.isReady.next(true); break;
      }
      case 'suggest': {
        if (this.suggestingProducts) this.isReady.next(true); break;
      }
    }
    return this.isReady.asObservable();
  }

  setIsReady(value: boolean) {
    this.isReady.next(value);
  }

  // Get and set
  getProducts(type: string) {
    switch (type) {
      case 'all': {
        return (this.allProducts);
      }
      case 'hotdeal': {
        return (this.hotdealProducts);
      }
      case 'new': {
        return (this.newProducts);
      }
      case 'suggest': {
        return (this.suggestingProducts);
      }
    }
    return [];
  }

  setProducts(type: string, data: Product[]) {
    switch (type) {
      case 'all': {
       this.allProducts = data;
      }
      case 'hotdeal': {
        this.hotdealProducts = data;
      }
      case 'new': {
        this.newProducts = data;
      }
      case 'suggest': {
        this.suggestingProducts = data;
      }
    }
  }
    
  // Http methods
  getAll(search: {}) {
    return this.http.get<Product[]>(AppConstants.ApiEndpoint + 'api/Product', { params: search} );
  }

  getBySection(type: string, search: {}) {
    return this.http.get<Product[]>(AppConstants.ApiEndpoint + 'api/Product/GetBySection?section=' + type, { params: search});
  }

  getByCategory(id: number, search: {}) {
    return this.http.get<Product[]>(AppConstants.ApiEndpoint + 'api/Product/GetByCategory?id=' + id, { params: search});
  }

  getById(id: number) {
    return this.http.get<Product>(AppConstants.ApiEndpoint + 'api/Product/GetById?id=' + id);
  }
}