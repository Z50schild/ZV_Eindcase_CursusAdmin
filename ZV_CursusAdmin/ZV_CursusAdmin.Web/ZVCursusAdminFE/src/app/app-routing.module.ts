import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CursusListComponent } from './cursus-list/cursus-list.component';
import { UploadComponent} from './upload/upload.component'


const routes: Routes = [
  {path: 'cursus', component: CursusListComponent },
  {path: 'upload', component: UploadComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
