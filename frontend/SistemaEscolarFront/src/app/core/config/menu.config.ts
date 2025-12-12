import {MenuItem} from '@app/core/models';
import {TipoUsuario} from '@app/core/enums';

const ROUTES = {
  PROFILE: '/profile',
  LOGOUT: '/auth/logout',
  COMMON: {
    MAP: '/common/mapa-curricular',
    OCUPABILIDAD: '/common/ocupabilidad',
    HORARIOS: '/common/horarios'
  }
};
export const MENU_CONFIG: Record<TipoUsuario, MenuItem[]> = {
  [TipoUsuario.alumno]: [
    {
      label: 'Inscripción',
      icon: 'how_to_reg',
      children: [
        { label: 'Comprobante Horario', route: '/alumno/comprobante', icon: 'receipt_long' },
        { label: 'Calificaciones', route: '/alumno/calificaciones', icon: 'grade' }
      ]
    },
    {
      label: 'Horarios',
      icon: 'schedule',
      children: [
        { label: 'Ocupabilidad', route: ROUTES.COMMON.OCUPABILIDAD, icon: 'event_available' },
        { label: 'Horarios de clase', route: '/alumno/horario-clases', icon: 'calendar_month' }
      ]
    },
    {
      label: 'Trámites',
      icon: 'description',
      children: [
        { label: 'Solicitud', route: '/alumno/tramites/solicitud', icon: 'post_add' },
        { label: 'Seguimiento', route: '/alumno/tramites/seguimiento', icon: 'search' }
      ]
    },
    {
      label: 'Datos Académicos',
      icon: 'school',
      children: [
        { label: 'Historial Académico', route: '/alumno/historial', icon: 'history_edu' },
        { label: 'Estado General', route: '/alumno/estado-general', icon: 'analytics' }
      ]
    },
    {
      label: 'Detalles Escolares',
      icon: 'info',
      children: [
        {label: 'Agenda Escolar', route: '/alumno/agenda', icon: 'view_agenda'},
        {label: 'Mapa Curricular', route: ROUTES.COMMON.MAP, icon: 'map'},
        {label: 'Equivalencias', route: '/alumno/equivalencias', icon: 'swap_horiz'},
        {label: 'Calendario ETS', route: '/alumno/calendario-ets', icon: 'event_note'}
      ]
    }
    ],
  [TipoUsuario.docente]: [
  {
    label: 'Periodo Escolar Actual',
    icon: 'date_range',
    children: [
      { label: 'Horario Actual', route: '/docente/horario', icon: 'calendar_today' },
      { label: 'Grupos', route: '/docente/grupos', icon: 'groups' }
    ]
  },
  {
    label: 'Horarios',
    icon: 'schedule',
    children: [
      { label: 'Ocupabilidad', route: ROUTES.COMMON.OCUPABILIDAD, icon: 'event_available' },
      { label: 'Horarios de clase', route: ROUTES.COMMON.HORARIOS, icon: 'class' }
    ]
  },
  {
    label: 'Detalles Escolares',
    icon: 'info',
    children: [
      { label: 'Agenda Escolar', route: '/docente/agenda', icon: 'view_agenda' },
      { label: 'Mapa Curricular', route: ROUTES.COMMON.MAP, icon: 'map' },
      { label: 'Calendario ETS', route: '/docente/calendario-ets', icon: 'event_note' }
    ]
  }
],
  [TipoUsuario.gestion]: [
    {
      label: 'Alumnos',
      route: '/gestion/alumnos',
      icon: 'face'
    },
    {
      label: 'Horarios',
      icon: 'schedule',
      children: [
        { label: 'Ocupabilidad', route: ROUTES.COMMON.OCUPABILIDAD, icon: 'event_available' },
        { label: 'Horarios de clase', route: ROUTES.COMMON.HORARIOS, icon: 'calendar_month' },
        { label: 'Editar Horarios', route: '/gestion/horarios-editar', icon: 'edit_calendar' }
      ]
    },
    {
      label: 'Trámites',
      icon: 'description',
      children: [
        { label: 'Solicitudes', route: '/gestion/tramites/solicitudes', icon: 'inbox' },
        { label: 'Seguimiento', route: '/gestion/tramites/seguimiento', icon: 'manage_search' }
      ]
    },
    {
      label: 'Detalles Escolares',
      icon: 'dns',
      children: [
        { label: 'Agenda Escolar', route: '/gestion/agenda', icon: 'view_agenda' },
        { label: 'Mapa Curricular', route: ROUTES.COMMON.MAP, icon: 'map' },
        { label: 'Equivalencias', route: '/gestion/equivalencias', icon: 'swap_horiz' },
        { label: 'Calendario ETS', route: '/gestion/calendario-ets', icon: 'event_note' }
      ]
    }
  ]
}
