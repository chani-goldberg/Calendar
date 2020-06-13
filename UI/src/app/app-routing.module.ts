import { NgModule } from '@angular/core';
import{LogPage} from './log/log.page';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { from } from 'rxjs';


const routes: Routes = [
  {
    path: '',
    loadChildren: () => import('./tabs/tabs.module').then(m => m.TabsPageModule)
  },
  // {
  //   path:'log',
  //   component:LogPage
  // },
 
  // {
  //   path: 'log',
  //   loadChildren: './log/log.module#LogModule'
  // }
];
@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
