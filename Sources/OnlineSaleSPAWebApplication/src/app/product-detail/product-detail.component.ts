import { Component, OnInit } from '@angular/core';
import { ConfigurationService } from '../service/configuration.service';
import { Product } from '../model/product';
import { Searchview } from '../model/searchview';
import { ProductService } from '../service/product.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.scss']
})
export class ProductDetailComponent implements OnInit {

  recommendedProducts: Product[] = [];
  selectedProduct = new Product();
  searchView: Searchview = { pageSize: 5, keySearch: '', pageIndex: 1 };


  constructor(
    private route: ActivatedRoute,
    private configService: ConfigurationService,
    private productService: ProductService) {

  }

  ngOnInit() {
    this.onLoadConfigurations();
    this.loadData();

  }

  onLoadConfigurations() {

  }

  loadData() {
    // replace top by new when the data already available 
    this.productService.getById(this.route.snapshot.queryParams.pid).subscribe((res) => {
      this.selectedProduct = res;
      // this.productService.setViewedProducts('top', res);
    },
      (err) => {
        console.log(err);
      }
    );
  }

}
