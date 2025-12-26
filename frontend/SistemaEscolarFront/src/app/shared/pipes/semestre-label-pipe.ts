import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'semestreLabel'
})
export class SemestreLabelPipe implements PipeTransform {

  transform(semestre: number): string {
    const etiquetas: Record<number, string> = {
      1: 'Primer semestre',
      2: 'Segundo semestre',
      3: 'Tercer semestre',
      4: 'Cuarto semestre',
      5: 'Quinto semestre',
      6: 'Sexto semestre',
      7: 'Séptimo semestre',
      8: 'Octavo semestre',
      9: 'Noveno semestre',
      10: 'Décimo semestre'
    };

    return etiquetas[semestre] || `${semestre}° Semestre`;
  }
}
