import { Component, OnInit } from '@angular/core';
import { ProductCategory } from '../model/product-category';
import { CategoryService } from '../service/category.service';

@Component({
  selector: 'app-top-category',
  templateUrl: './top-category.component.html',
  styleUrls: ['./top-category.component.scss']
})
export class TopCategoryComponent implements OnInit {

  categories: ProductCategory[];

  constructor(private categoryService: CategoryService) { }

  ngOnInit() {
    this.loadConfiguration();
    this.loadData();
  }

  loadConfiguration() { }

  loadData() {
    this.categoryService.getIsReady('top').subscribe((val) => {
      if(val) {
      this.categories =  this.categoryService.getSections('top');
    }
    });
  }

}
