import {Component, OnInit} from  '@angular/core';
import {FormBuilder, FormGroup} from '@angular/forms';
import {UploadService} from './upload.service'

@Component({
    selector: 'app-upload',
    templateUrl: './upload.component.html',
    styleUrls: ['./upload.component.css']
})

export class UploadComponent implements OnInit {
    constructor (private formBuilder: FormBuilder, private uploadService: UploadService) {}
    fileToUload: File = null;
    form: FormGroup;
    error: string;
    uploadResponse = {status: '', message:'', filepath: ''};

    ngOnInit(){
        this.form= this.formBuilder.group({
            filestring: ['']
          });
        }
      
  onFileChange(event) {
   if (event.target.files.length > 0) {
     const file = event.targetfiles[0];
     this.form.get('filestring').setValue(file);
   }
  } 

  onSubmit() {
    const formData = new FormData();
    formData.append('file', this.form.get('filestring').value);

    this.uploadService.upload(formData).subscribe(
      (res) => this.uploadResponse = res,
      (err) => this.error = err
    );
  }
}
