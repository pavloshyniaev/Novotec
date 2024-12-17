import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root' // Makes the service globally available
})
export class SynchronizerService {
  private apiBaseUrl = 'https://localhost:7240/api'; // Change this to your actual backend URL

  constructor(private http: HttpClient) {}

  // === EMPLOYEE API CALLS ===
  updateEmployeeFull(): Observable<any> {
    return this.http.post(`${this.apiBaseUrl}/Employee/synchronize`, {});
  }

  updateEmployeePartial(): Observable<any> {
    return this.http.post(`${this.apiBaseUrl}/Employee/synchronize`, {});
  }

  getAllEmployees(): Observable<any> {
    return this.http.get(`${this.apiBaseUrl}/Employee`);
  }

  // === VEHICLE API CALLS ===
  updateVehicleFull(): Observable<any> {
    return this.http.post(`${this.apiBaseUrl}/Vehicle/synchronize`, {});
  }

  updateVehiclePartial(): Observable<any> {
    return this.http.post(`${this.apiBaseUrl}/Vehicle/synchronize`, {});
  }

  getAllVehicles(): Observable<any> {
    return this.http.get(`${this.apiBaseUrl}/Vehicle`);
  }

  // === UTILITY METHODS ===
  // Process the combined records for updated/deleted employees
  processEmployeeData(data: any[]): { updatedEmployees: any[], deletedEmployees: any[] } {
    const updatedEmployees = data.filter(emp => emp.status === 'Updated');
    const deletedEmployees = data.filter(emp => emp.status === 'Deleted');
    return { updatedEmployees, deletedEmployees };
  }

  // Process the combined records for updated/deleted vehicles
  processVehicleData(data: any[]): { updatedVehicles: any[], deletedVehicles: any[] } {
    const updatedVehicles = data.filter(veh => veh.status === 'Updated');
    const deletedVehicles = data.filter(veh => veh.status === 'Deleted');
    return { updatedVehicles, deletedVehicles };
  }
}
