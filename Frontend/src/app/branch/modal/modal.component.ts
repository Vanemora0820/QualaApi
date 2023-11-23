import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { BranchModel } from 'src/app/models/BranchModel';



@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.css']
})
export class ModalComponent {

  @Output() save: EventEmitter<string> = new EventEmitter();
  //branch: FormGroup ;
  @Input() createBool = false;
  //@Input() item: Branch;
  mensaje='';

  constructor( private formBuilder:FormBuilder,
    branch: BranchModel
    
    ){}
  ngOnInit(): void{
    //this.iniciarForm();

  }
  // ngOnChanges(changes: SimpleChanges): void {
  //   if(this.createBool){
  //     this.mensaje = 'Crear branch'
  //   }
  //   else{
  //     this.mensaje = 'Actualiza branch'
  //     console.log(this.item);
  //     if(this.item){
  //       this.updateForm();
  //     }
  //   }
  // }
  // iniciarForm(){
  //   this.branch = this.formBuilder.group({
  //     address: new FormControl(''),
  //     description: new FormControl(''),
  //     coinId: new FormControl('')
  //   });
  // }
  // updateForm(){
  //   this.branch = this.formBuilder.group({
  //     address: new FormControl(this.item.address),
  //     description: new FormControl(this.item.description),
  //     coinId: new FormControl(this.item.coinId)
  //   });
  // }
  // createbranch(){

  //   this.branch.createBranch(this.generarRequest()).subscribe(data => {
  //     console.log(data);

  //   });
  // }
  // generarRequest(): Branch{
  //   var request: Branch = new Branch();
  //   request.description = this.branch.value.description;
  //   request.address = this.branch.value.address;    
  //   request.coinId = this.branch.value.coinId;
  //   request.id = 0;
  //   request.creationDate = new Date();
  //   console.log(request);

  //   return request;
  // }
  orquestador(){
    // if (!this.createBool){
    //   this.updatebranch();
    // }else{
    //   this.createbranch();
    // }
  }
  // updatebranch(){
  //   var resquest = this.generarRequest();
  //   resquest.id = this.item.id;
  //   this.branchService.updatebranch(resquest).subscribe(data => {
  //     if(data){
  //       this.sendInfo();
  //     }

  //   });
  // }
  sendInfo(){
    this.save.emit("");
  }


}
