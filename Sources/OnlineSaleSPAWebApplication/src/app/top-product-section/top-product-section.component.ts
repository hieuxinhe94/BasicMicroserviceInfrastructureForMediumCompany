import { Component, OnInit } from '@angular/core';
import { ProductService } from '../service/product.service';
import { Product } from '../model/product';
import { Searchview } from '../model/searchview';

@Component({
  selector: 'app-top-product-section',
  templateUrl: './top-product-section.component.html',
  styleUrls: ['./top-product-section.component.scss']
})
export class TopProductSectionComponent implements OnInit {

  products: Product[] = [];
  searchView : Searchview = { pageSize : 10, keySearch: '', pageIndex : 1};
  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.loadConfiguration();
    this.loadData();
  }

  loadConfiguration(){}

  loadData() {
    this.productService.getBySection('top', this.searchView).subscribe( (res) => {
        this.products = res;
        this.productService.setProducts('top', res);
    }, 
    (err) => {
        console.log(err);
    }
    )
  }

}
