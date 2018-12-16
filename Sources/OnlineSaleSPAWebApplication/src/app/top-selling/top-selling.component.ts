import { Component, OnInit } from '@angular/core';
import { Product } from '../model/product';
import { Searchview } from '../model/searchview';
import { ProductService } from '../service/product.service';

@Component({
  selector: 'app-top-selling',
  templateUrl: './top-selling.component.html',
  styleUrls: ['./top-selling.component.scss']
})
export class TopSellingComponent implements OnInit {

  products: Product[] = [];
  searchView: Searchview = { pageSize: 10, keySearch: '', pageIndex: 1 };
  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.loadConfiguration();
    this.loadData();
  }

  loadConfiguration() { }

  loadData() {
    this.productService.getBySection('top', this.searchView).subscribe((res) => {
      this.products = res;
      this.productService.setProducts('top', res);
    },
      (err) => {
        console.log(err);
      }
    );
  }

}