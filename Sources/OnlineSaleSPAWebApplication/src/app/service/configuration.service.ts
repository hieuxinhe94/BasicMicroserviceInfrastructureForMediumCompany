import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Configuration } from '../model/configurations';
import { AppConstants } from '../model/appConstants';
import { BehaviorSubject } from 'rxjs';
import { Menu } from '../model/menu';

@Injectable({
  providedIn: 'root'
})
export class ConfigurationService {

  // Declare object store datas
  appParams: Configuration[] = [];
  appMenus: Menu[] = [];

  // declare state objects
  public isReady = new BehaviorSubject<boolean>(false);
  public isMenuReady = new BehaviorSubject<boolean>(false);

  constructor(private http: HttpClient) {
  }

  // state of data
  getIsReady() {
    return this.isReady.asObservable();
  }

  getIsMenuReady() {
    return this.isMenuReady.asObservable();
  }

  setIsReady(value: boolean) {
    this.isReady.next(value);
  }

  setIsMenuReady(value: boolean) {
    this.isMenuReady.next(value);
  }

  // Get and set
  get getAppParams() {
    return this.appParams;
  }

  get getMenus() {
    return this.appMenus;
  }

  getKeyValue(key) {
    let val = this.appParams.find(t => t.key === key);
    if (val) {
      return val.value;
    }
    return '';
  }

  setAppParams(data: Configuration[]) {
    this.appParams = data;
  }

  setMenus(data: Menu[]) {
    this.appMenus = data;
  }

  // Http methods
  getAll() {
    return this.http.get<Configuration[]>(AppConstants.ApiEndpoint + 'api/AppParam');
  }

  getAllMenu() {
    return this.http.get<Menu[]>(AppConstants.ApiEndpoint + 'api/Menu');
  }

  getById(id: number) {
    return this.http.get<Configuration>(AppConstants.ApiEndpoint + 'api/AppParam?id=' + id);
  }

  getMenuById(id: number) {
    return this.http.get<Configuration>(AppConstants.ApiEndpoint + 'api/Menu?id=' + id);
  }

  create(param: Configuration) {
    return this.http.post<Configuration>(AppConstants.ApiEndpoint + 'api/AppParam', param);
  }

  createMenu(param: Menu) {
    return this.http.post<Menu>(AppConstants.ApiEndpoint + 'api/Menu', param);
  }

  delete(id: number) {
    return this.http.delete<Configuration>(AppConstants.ApiEndpoint + 'api/AppParam?id=' + id);
  }

  deleteMenu(id: number) {
    return this.http.delete<Configuration>(AppConstants.ApiEndpoint + 'api/Menu?id=' + id);
  }

}
