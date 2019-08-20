import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { AppointmentsService } from './api/EngagementOrganizerApiClient/api/appointments.service';

@Injectable({
  providedIn: 'root'
})
export class AppontmentResolver implements Resolve<any> {
  constructor(private appointmentService: AppointmentsService) {
  }
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    return this.appointmentService.getAppointments(route.params["year?"]);
  }
}
