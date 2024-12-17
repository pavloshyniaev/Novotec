import { Component } from '@angular/core';
import { SynchronizerService } from './api/synchronizer.service'; // Import the service
import { ButtonsModule } from '@progress/kendo-angular-buttons';
import { GridModule } from '@progress/kendo-angular-grid';
import { DropDownListModule } from '@progress/kendo-angular-dropdowns';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { LabelModule } from "@progress/kendo-angular-label";

@Component({
  selector: 'app-synchronizer',
  standalone: true,
  imports: [CommonModule, FormsModule, ButtonsModule, GridModule, DropDownListModule, LabelModule],
  templateUrl: './synchronizer.component.html',
  styleUrls: ['./synchronizer.component.css']
})
export class SynchronizerComponent {
  employees: any[] = [];
  updatedEmployees: any[] = [];
  deletedEmployees: any[] = [];
  
  vehicles: any[] = [];
  updatedVehicles: any[] = [];
  deletedVehicles: any[] = [];

  selectedEntityType: 'Employee' | 'Vehicle' = 'Employee';
  selectedRecordType: 'All' | 'Updated' | 'Deleted' = 'All';

  entityOptions = ['Employee', 'Vehicle'];
  recordTypeOptions = ['All', 'Updated', 'Deleted'];

  constructor(private synchronizerService: SynchronizerService) {}

  ngOnInit() {
    this.loadAllEmployees();
    this.loadAllVehicles();
  }

  loadAllEmployees() {
    this.synchronizerService.getAllEmployees().subscribe((response: any) => {
      this.employees = response.employees;
      const { updatedEmployees, deletedEmployees } = this.synchronizerService.processEmployeeData(this.employees);
      this.updatedEmployees = updatedEmployees;
      this.deletedEmployees = deletedEmployees;
    });
  }

  loadAllVehicles() {
    this.synchronizerService.getAllVehicles().subscribe((response: any) => {
      this.vehicles = response.vehicles;
      const { updatedVehicles, deletedVehicles } = this.synchronizerService.processVehicleData(this.vehicles);
      this.updatedVehicles = updatedVehicles;
      this.deletedVehicles = deletedVehicles;
    });
  }

  // === Count Getters ===
  get updatedEmployeeCount(): number {
    return this.updatedEmployees.length;
  }

  get deletedEmployeeCount(): number {
    return this.deletedEmployees.length;
  }

  get updatedVehicleCount(): number {
    return this.updatedVehicles.length;
  }

  get deletedVehicleCount(): number {
    return this.deletedVehicles.length;
  }

  get currentGridData() {
    switch (this.selectedEntityType) {
      case 'Employee':
        switch (this.selectedRecordType) {
          case 'All':
            return this.employees;
          case 'Updated':
            return this.updatedEmployees;
          case 'Deleted':
            return this.deletedEmployees;
        }
        break;
      
      case 'Vehicle':
        switch (this.selectedRecordType) {
          case 'All':
            return this.vehicles;
          case 'Updated':
            return this.updatedVehicles;
          case 'Deleted':
            return this.deletedVehicles;
        }
        break;

      default:
        return [];
    }
  }

  updateEmployeeFull() {
    this.synchronizerService.updateEmployeeFull().subscribe(() => this.loadAllEmployees());
  }

  updateEmployeePartial() {
    this.synchronizerService.updateEmployeePartial().subscribe(() => this.loadAllEmployees());
  }

  updateVehicleFull() {
    this.synchronizerService.updateVehicleFull().subscribe(() => this.loadAllVehicles());
  }

  updateVehiclePartial() {
    this.synchronizerService.updateVehiclePartial().subscribe(() => this.loadAllVehicles());
  }
}
