import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  

//plain properties
firstName ="Nikhil";
lastName = "Shah";
designation  = "Consultant";
country = "India";

//Plain Array Properties
technologies =['Net','Angular','Azure','SQL Server','MSBI'];
countriesTrainedIn = ['Singapore','Canada','Phillipines','Malayasia','Hong-Kong'];

//JSON Object
trainerProfile = {
  trainerId:101,
technologyStack:'Microsoft',
trainerLocation:'India',
trainerYearsofExperience:15,
trainerClients:['Microsoft','Accenture','Infosys','BOA','MasterCard']
}

//JSON Object Array
trainerist = [
  { trainerId:101,trainerName:'Nikhil',technologyStack:'Microsoft', trainerLocation:'India', trainerYearsofExperience:15},
  { trainerId:102,trainerName:'John', technologyStack:'Java', trainerLocation:'Canada', trainerYearsofExperience:15},
  { trainerId:103,trainerName:'Peter', technologyStack:'Client Frameworks', trainerLocation:'Japan', trainerYearsofExperience:15},
  { trainerId:104,trainerName:'Michelle', technologyStack:'Database', trainerLocation:'Malayasia', trainerYearsofExperience:15},
  { trainerId:105,trainerName:'Micheal', technologyStack:'Cloud', trainerLocation:'Hong-Kong', trainerYearsofExperience:15},
  { trainerId:106,trainerName:'Kyle', technologyStack:'Reporting', trainerLocation:'Netherlands', trainerYearsofExperience:15},
  { trainerId:107,trainerName:'Jenny', technologyStack:'Web', trainerLocation:'South Asia', trainerYearsofExperience:15},
]
}
