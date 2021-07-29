import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { PersonaSerService } from 'src/app/services/persona-ser.service';

@Component({
  selector: 'app-fre1',
  templateUrl: './fre1.component.html',
  styleUrls: ['./fre1.component.css']
})





export class Fre1Component implements OnInit {

  listarPersonas: any[]=[];
  listarZona: any[]=[];
  listarSector: any[]=[];
  accion= 'Agregar';
  Variabl= '';
  cod_ector: any[]=[];
  AgruparSector: any[]=[];
  form: FormGroup;
  cod_persona: number | undefined;

  cod_zona: number | undefined;
  constructor(private fb: FormBuilder, private toastr: ToastrService, private _personaService: PersonaSerService) { 

    this.form =this.fb.group( {
      cod_persona:[""],
      nom_persona:["", Validators.required],
      fec_nacimiento:["",[Validators.required, Validators.maxLength(10), Validators.minLength(8)]],
      cod_sector:["",Validators.required],
      cod_zona:["",Validators.required],
      sueldo:["",[Validators.required  ,Validators.minLength(1)]] 

    })
  }

  ngOnInit(): void {
    this.obtenerPersonas();
    this.obtenerSector();
    
 this.generarid();
   
  }


  generarid(){
    this.cod_persona=0;
  }
  obtenerPersonas(){
   this. Variabl= '';

    this._personaService.getListaPersonas().subscribe(data => {
      console.log(data);
      this.listarPersonas = data;
      console.log(this.listarPersonas);

     
    }, error => {  
      console.log(error);
      
    })
  }

  obtenerSector(){
    this._personaService.getListaSector().subscribe(data => {
      console.log(data);
      this.listarSector = data;
      console.log(this.listarSector);

     
    }, error => {  
      console.log(error);
      
    })
  }






  obtenerZona(id :  number){


  
    //this._personaService.getListaZona(id).subscribe(data => {
     
      this._personaService.getListaZona(id).subscribe(data => {
        //this.toastr.error('la personas fue Eliminada con exito', 'Personas Eliminada');
        console.log(data);
        this.listarZona = data;
        console.log(this.listarZona);
        this.listarZona;
        console.log(this.listarZona);
    
  
}, error =>{
  console.log(error);
  
})



  }




  AgregarPersonas(){
    console.log(this.form);

    const personas: any= {  
      cod_persona: this.form.get("cod_persona")?.value,
      
      nom_persona: this.form.get("nom_persona")?.value,
      fec_nacimiento: this.form.get("fec_nacimiento")?.value,
    cod_sector: this.form.get("cod_sector")?.value,
      cod_zona: this.form.get("cod_zona")?.value,
      sueldo: this.form.get("sueldo")?.value,
    
    
    }

    if(this.cod_persona == undefined)
    {
      // Agregar una personas
      this.cod_persona=0;
      this._personaService.savePersona(personas+this.cod_persona).subscribe(data => {
        this.toastr.success('la personas fue registrada con exito', 'Personas Resgistrada');
        console.log(personas);
        this.obtenerPersonas();
        this.form.reset();
     }, error => {
      console.log(personas);
       this.toastr.error('ocurrio un erro','ERROR')
       console.log(error);
     })
    } else {
      personas.cod_persona= this.cod_persona;
      // Actualizamos una Persona

      this._personaService.updatePersonas(this.cod_persona,personas).subscribe(data => {

        this.form.reset();
        this.accion='Actualizar';
        this.cod_persona = undefined;
        this.toastr.info('La persona fue actualizada con exito',' Persona Actualizada');
        this.obtenerPersonas();
     
      },error => {
        console.log(error);
        
      }
      )
    }
    //this.listarPersonas.push(personas)
    
   
     }

  eliminarpersona(id: number) 
  {
//this.listarPersonas.splice(index, 1);
this._personaService.deletePersona(id).subscribe(data => {
  this.toastr.error('la personas fue Eliminada con exito', 'Personas Eliminada');
  this.obtenerPersonas();
  console.log(id);

}, error =>{
  console.log(error);
  
})
  }


  AgruparporSector(id: number){


    this. Variabl= 'd';
    
    this._personaService.getlistaAgrupadaXsector(id).subscribe(data => {
      //this.toastr.error('la personas fue Eliminada con exito', 'Personas Eliminada');
      console.log(data);
      this.AgruparSector = data;
      console.log(this.AgruparSector);
      this.AgruparSector;
      console.log(this.AgruparSector);
  

}, error =>{
console.log(error);

})

  }

  


  editarPersona(personas: any){

     
    this.accion = 'Editar';
    this.cod_persona = personas.cod_persona,
   
    console.log(this.cod_persona);

    this.form.patchValue(
      {
        cod_persona: personas.cod_persona,
        nom_persona: personas.nom_persona,
        fec_nacimiento: personas.fec_nacimiento,
        cod_sector: personas.cod_sector,
        cod_zona: personas.cod_zona,
        sueldo: personas. sueldo
      }
    )
    console.log(personas.cod_zona);
    console.log(personas);

  }







  
}
