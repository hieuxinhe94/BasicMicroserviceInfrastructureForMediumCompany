import { Component } from '@angular/core';
import { LoginService } from './service/login.service';
import { AppConstants } from './model/appConstants';
import { ConfigurationService } from './service/configuration.service';
import { CategoryService } from './service/category.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'laptop-tuanhoang-ui';
  
  /**
   *
   */
  constructor(
    private loginService: LoginService,
    private categoryService: CategoryService,
    private configService: ConfigurationService) {
      this.loginToService();
      this.initConfigs();
      this.initMenuConfig();
      this.initTopCategoryConfig();
  }

  loginToService() {
    // login to the platform
    this.loginService.login(AppConstants.AppLoginName, AppConstants.AppLoginPassword)
      .subscribe((res) => {
        this.loginService.setSession(res);
      },
        (err) => {
          console.log(err);
        });
  }

  initConfigs() {
    this.configService.getAll().subscribe((res) => {
      this.configService.setAppParams(res);
      this.configService.setIsReady(true);
     }, (err) => { 
      console.log(err);
     });
  }

  initMenuConfig() {
    this.configService.getAllMenu().subscribe((res) => {
      this.configService.setMenus(res);
      this.configService.setIsMenuReady(true);
     }, (err) => { 
      console.log(err);
     });
  }

  initTopCategoryConfig() {
    this.categoryService.getAll().subscribe((res) => {
      this.categoryService.setProducts('all', res);
    },
      (err) => {
        console.log(err);
      }
    );
  }
}
