import { Component, OnInit } from '@angular/core';
import { Product } from '../model/product';
import { Searchview } from '../model/searchview';
import { ProductService } from '../service/product.service';

@Component({
  selector: 'app-top-lastest',
  templateUrl: './top-lastest.component.html',
  styleUrls: ['./top-lastest.component.scss']
})
export class TopLastestComponent implements OnInit {

  products: Product[] = [];
  searchView: Searchview = { pageSize: 10, keySearch: '', pageIndex: 1 };
  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.loadConfiguration();
    this.loadData();
  }

  loadConfiguration() { }

  loadData() {
    // replace top by new when the data already available 
    this.productService.getBySection('top', this.searchView).subscribe((res) => {
      this.products = res;
      this.productService.setProducts('top', res);
    },
      (err) => {
        console.log(err);
      }
    );
  }

  counter(i: number) {
    return new Array(i);
}

}
