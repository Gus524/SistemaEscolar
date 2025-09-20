USE db_escolar;

-- Ingenieria en Informatica
-- Semestre 1
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Matemáticas discretas', 3, 1, 1),
('Obligatoria', 'Fundamentos de física', 4, 0, 3),
('Obligatoria', 'Física general experimental', 0, 2, 3),
('Obligatoria', 'Comunicación profesional interdisciplinaria', 2, 1, 6),
('Obligatoria', 'Fundamentos de administración', 3, 1, 5),
('Obligatoria', 'Responsabilidad social y ética', 2, 1, 6),
('Obligatoria', 'Lógica de programación', 2, 2, 2);

-- Semestre 2
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Cálculo diferencial e integral', 3, 1, 1),
('Obligatoria', 'Psicología en el trabajo', 2, 1, 6),
('Obligatoria', 'Metodología de la investigación', 2, 1, 6),
('Obligatoria', 'Sistemas digitales', 1, 2, 2),
('Obligatoria', 'Aplicación de sistemas digitales', 2, 1, 2),
('Obligatoria', 'Fundamentos de ingeniería de software', 2, 2, 2),
('Obligatoria', 'Estructura de datos', 2, 2, 2),
('Obligatoria', 'Programación de bajo nivel', 2, 2, 2);

-- Semestre 3
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Probabilidad', 3, 1, 1),
('Obligatoria', 'Algoritmos computacionales', 2, 2, 2),
('Obligatoria', 'Ingeniería de requerimientos', 2, 2, 2),
('Obligatoria', 'Diseño de interfaces de usuario', 2, 1, 2),
('Obligatoria', 'Arquitectura y organización de las computadoras', 3, 1, 2),
('Obligatoria', 'Construcción de bases de datos', 2, 2, 2),
('Obligatoria', 'Programación orientada a objetos', 2, 2, 2);

-- Semestre 4
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Estadística', 3, 1, 1),
('Obligatoria', 'Dispositivos programables', 1, 3, 2),
('Obligatoria', 'Ingeniería de diseño', 2, 2, 2),
('Obligatoria', 'Administración de bases de datos', 2, 2, 2),
('Obligatoria', 'Seguridad informática', 2, 2, 2),
('Obligatoria', 'Sistemas operativos', 3, 1, 2),
('Obligatoria', 'Adquisición de datos', 2, 2, 2);

-- Semestre 5
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Álgebra lineal', 3, 1, 1),
('Obligatoria', 'Métodos numéricos', 3, 1, 1),
('Obligatoria', 'Contabilidad financiera y de costos', 3, 1, 5),
('Obligatoria', 'Aplicación de la ciencia económica', 3, 1, 5),
('Obligatoria', 'Teoría de la computación y compiladores', 3, 1, 2),
('Obligatoria', 'Comunicación de datos', 3, 1, 2),
('Obligatoria', 'Programación WEB', 2, 2, 2);

-- Semestre 6
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Modelos determinísticos de investigación de operaciones', 3, 1, 1),
('Obligatoria', 'Ingeniería económica', 2, 1, 5),
('Obligatoria', 'Presupuesto y finanzas', 3, 1, 5),
('Obligatoria', 'Redes y conectividad', 3, 1, 2),
('Obligatoria', 'Fundamentos de inteligencia artificial', 3, 1, 2),
('Obligatoria', 'Ingeniería de pruebas', 2, 2, 2),
('Obligatoria', 'Programación móvil', 2, 2, 2);

-- Semestre 7
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Redes y modelos de simulación', 3, 1, 2),
('Obligatoria', 'Administración estratégica', 2, 2, 5),
('Obligatoria', 'Legislación informática', 3, 1, 2),
('Obligatoria', 'Formulación y evaluación de proyectos', 1, 3, 5),
('Obligatoria', 'Ingeniería del conocimiento', 2, 2, 2),
('Obligatoria', 'Internet de las cosas', 2, 2, 2),
('Obligatoria', 'Seguridad en redes', 3, 1, 2);

-- Semestre 8
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Habilidades directivas', 1, 2, 5),
('Obligatoria', 'Informática empresarial', 2, 1, 2),
('Obligatoria', 'Proyecto de titulación', 0, 3, 2),
('Obligatoria', 'Gestión de proyectos', 1, 3, 5),
('Obligatoria', 'Calidad y normalización de software', 2, 2, 2),
('Obligatoria', 'Administración de tecnologías', 2, 2, 2),
('Obligatoria', 'Fundamentos de analítica de datos', 2, 2, 2),
('Obligatoria', 'Computación en la nube', 2, 2, 2);

-- Optativas 
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Optativa', 'Hackeo ético (Informática)', 2, 1, 2),
('Optativa', 'Virología y criptografía (Computación)', 2, 1, 4),
('Optativa', 'Monitoreo y administración de redes (Computación)', 2, 1, 4),
('Optativa', 'Escenarios virtuales (Computación)', 2, 1, 4),
('Optativa', 'Ambientes virtuales inmersivos (Computación)', 2, 1, 4),
('Optativa', 'Simuladores virtuales (Computación)', 2, 1, 4),
('Optativa', 'Sistemas embebidos (Laboratorio de electricidad y control)', 2, 1, 7),
('Optativa', 'Informática en ambientes productivos (Producción)', 2, 1, 8),
('Optativa', 'Big Data y toma de decisiones (Informática)', 2, 1, 2);

--  Materias Ingenieria Industrial (Se omiten las materias que ya se registraron)
-- Semestre 1
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Cálculo vectorial', 3, 0, 15), -- Ciencias Basicas de la Ingenieria
('Obligatoria', 'Dibujo industrial asistido por computadora', 1, 2, 16), -- Ingenieria Industrial
('Obligatoria', 'Tecnologia informática', 1, 3, 2); -- Informática

-- Semestre 2
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Mecánica clasica', 4, 0, 15), -- Ciencias Basicas de la Ingenieria
('Obligatoria', 'Laboratorio de mecánica clásica', 0, 2, 15), -- Ciencias Basicas de la Ingenieria
('Obligatoria', 'Administración de capital humano', 1, 3, 5), -- Administración
('Obligatoria', 'Legislación industrial', 3, 1, 10), -- Derecho 
('Obligatoria', 'Comunicación profesional', 2, 1, 6); -- Humanidades y Ciencias Sociales

-- Semestre 3
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Electromagnetismo', 4, 0, 3), -- Fisica
('Obligatoria', 'Laboratorio de electromagnetismo', 0, 2, 3), -- Fisica
('Obligatoria', 'Métodos matemáticos', 3, 1, 1), -- Matemáticas
('Obligatoria', 'Quimica aplicada', 4, 0, 9), -- Quimica
('Obligatoria', 'Laboratorio de química aplicada', 0, 2, 9), -- Quimica
('Obligatoria', 'Mecánica de materiales', 2, 1, 15), -- Ciencias Basicas de la Ingenieria
('Obligatoria', 'Diseño y evaluación de estándares de trabajo', 0, 2, 16), -- Ingenieria Industrial
('Obligatoria', 'Productividad y diseño del trabajo', 3, 0, 16); -- Ingenieria Industrial

-- Semestre 4
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Nonnalización y metrologia dimensional', 1, 2, 16), -- Ingenieria Industrial
('Obligatoria', 'Dinamica de mecanismos', 2, 1, 15), -- Ciencias Basicas de la Ingenieria
('Obligatoria', 'Quimica industrial', 4, 0, 9), -- Quimica
('Obligatoria', 'Laboratorio de quimica industrial', 0, 2, 9), -- Quimica
('Obligatoria', 'Electricidad y electrónica', 3, 0, 7), -- Laboratorio de Electricidad y Control
('Obligatoria', 'Tecnologia de materiales', 3, 0, 20), -- Laboratorios de Procesos de Manufactura
('Obligatoria', 'Sistemas neumáticos hidráulicos', 1, 2, 23); -- Laboratorios de Sistemas Automotrices

-- Semestre 5
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Plantas y procesos industriales', 3, 0, 16), -- Ingenieria Industrial
('Obligatoria', 'Electricidad aplicada', 1, 1, 7), -- Laboratorio de Electricidad y Control
('Obligatoria', 'Determinación y aplicación de estándares', 3, 0, 16), -- Ingenieria Industrial
('Obligatoria', 'Ingenieria de estándares', 0, 2, 16), -- Ingenieria Industrial
('Obligatoria', 'Pruebas de control de calidad', 0, 3, 21), -- Laboratorios de Control de Calidad
('Obligatoria', 'instrumentación y control', 3, 0, 7), -- Laboratorio de Electricidad y Control
('Obligatoria', 'Planeación financiera', 3, 1, 11), -- Finanzas
('Obligatoria', 'Mercadotecnia', 3, 1, 12), -- Mercadotecnia y Recursos Humanos
('Obligatoria', 'Planeación y control de imentarios', 3, 1, 16); -- Ingenieria Industrial

-- Semestre 6
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Modelos estocásticos de investigación de operaciones', 3, 1, 17), -- Investigacion de Operaciones
('Obligatoria', 'Planeación y control maestro de la producción', 3, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Conformado de materiales', 1, 1, 20), -- Laboratorios de Procesos de Manufactura
('Obligatoria', 'Manufactura esbelta', 2, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Distribución de planta y manejo de materiales', 3, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Sistemas hibridos', 1, 1, 2), -- Informática
('Obligatoria', 'Manufactura integral', 2, 1, 16); -- Ingenieria Industrial

-- Semestre 7
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Mecanizado industrial', 1, 1, 20), -- Laboratorios de Procesos de Manufactura
('Obligatoria', 'Manufactura aditiva y sustractiva', 1, 2, 20), -- Laboratorios de Procesos de Manufactura
('Obligatoria', 'Mantenimiento', 3, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Seguridad y salud en el trabajo', 3, 1, 16), -- Ingenieria Industrial 
('Obligatoria', 'Logistica', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Simulación de sistemas', 3, 1, 2), -- Informática
('Obligatoria', 'Gestión de la innovación', 2, 1, 5); -- Administración

-- Semestre 8
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Gestión de la cadena de suministro', 2, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Gestión ambiental', 3, 1, 9), -- Quimica
('Obligatoria', 'Sistemas integrados de manufactura', 2, 2, 16), -- Ingenieria Industrial
('Obligatoria', 'Gestión de proyectos', 1, 3, 5), -- Administración
('Obligatoria', 'Emprendimiento', 1, 2, 5), -- Administración
('Obligatoria', 'Sistemas de gestión de calidad', 1, 2, 21), -- Laboratorios de Control de Calidad
('Obligatoria', 'Habilidades directivas', 1, 2, 5); -- Administración

-- Optativas
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Optativa', 'Diseño y validación de un prototipo', 1, 2, 16), -- Ingenieria Industrial
('Optativa', 'Desarrollo del producto', 1, 2, 16), -- Ingenieria Industrial
('Optativa', 'Planificación avanzada de la calidad del producto', 1, 2, 21), -- Laboratorios de Control de Calidad
('Optativa', 'Seguridad en el trabajo', 1, 2, 16), -- Ingenieria Industrial
('Optativa', 'Salud en el trabajo', 1, 2, 16), -- Ingenieria Industrial
('Optativa', 'Gestión de riesgo y protección civil', 1, 2, 16), -- Ingenieria Industrial
('Optativa', 'Ingenieria de operaciones', 1, 2, 17), -- Investigacion de Operaciones
('Optativa', 'Solución a problemas de la alta dirección', 1, 2, 5), -- Administración
('Optativa', 'Implementación de sistemas de gestión', 1, 2, 5), -- Administración
('Optativa', 'Tecnologias inteligentes', 1, 2, 2), -- Informática
('Optativa', 'Integración de las tecnologías en la industria 5.0', 1, 2, 2), -- Informática
('Optativa', 'Comercialización internacional y digital', 1, 2, 13); -- Economia

-- Ingenieria en transporte
-- Semestre 1
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Fundamentos matemáticos', 4, 0, 15), -- Ciencias Basicas de la Ingenieria
('Obligatoria', 'Elementos del cálculo vectorial', 3, 0, 15), -- Ciencias Basicas de la Ingenieria
('Obligatoria', 'Dibujo asistido por computadora', 1, 3, 16), -- Ingenieria Industrial
('Obligatoria', 'Sistemas y la ingenieria en transporte', 3, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Metodologia de la ingenieria', 2, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Comunicación profesional interdisciplinaria', 2, 1, 6); -- Humanidades y Ciencias Sociales

-- Semestre 2
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Mecánica clásica', 4, 0, 15), -- Ciencias Basicas de la Ingenieria
('Obligatoria', 'Laboratorio de mecánica clásica', 0, 2, 15), -- Ciencias Basicas de la Ingenieria
('Obligatoria', 'Proyecto de vias terrestres', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Sistemas de información geográfica', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Sistema de transporte carretero', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Sistema de transporte ferroviario', 2, 1, 18); -- Sistemas de Transporte

-- Semestre 3
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Química energética y ambiental', 4, 0, 9), -- Quimica
('Obligatoria', 'Laboratorio de química energética y ambiental', 0, 2, 9), -- Quimica
('Obligatoria', 'Sistema de transporte marítimo', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Sistema de transporte aéreo', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Programación y bases de datos', 2, 1, 2); -- Informática

-- Semestre 4
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Tecnología de vehículos y laboratorios', 3, 1, 23), -- Laboratorios de Sistemas Automotrices
('Obligatoria', 'Sistema de transporte multimodal', 3, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Ingeniería de tránsito', 3, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Legislación para el transporte', 3, 1, 10), -- Derecho
('Obligatoria', 'Tecnología aplicada al transporte', 2, 1, 18); -- Sistemas de Transporte

-- Semestre 5
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Matemáticas aplicadas', 3, 1, 1), -- Matemáticas
('Obligatoria', 'Estadística aplicada', 3, 1, 1), -- Matemáticas
('Obligatoria', 'Administración estratégica para el transporte', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Gestión y seguridad de pasajeros y carga', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Cadena de suministro de proceso', 3, 1, 16); -- Ingenieria Industrial

-- Semestre 6
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Macroeconomía', 3, 1, 13), -- Economia
('Obligatoria', 'Capital humano en empresas de transporte', 3, 1, 5), -- Administración
('Obligatoria', 'Ingeniería en transporte terrestre', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Planeación del transporte', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Cadena de suministro, almacenes e inventarios', 2, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Economía de la ingeniería', 3, 1, 13); -- Economia

-- Semestre 7
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Modelos de reemplazo y mantenimiento', 2, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Ingeniería en transporte aéreo', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Ingeniería en transporte marítimo', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Cadena de suministro diseño de red', 2, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Seguridad integral del transporte', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Modelos de transporte', 2, 1, 18); -- Sistemas de Transporte

-- Semestre 8
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Proyecto de titulación', 1, 3, 18), -- Sistemas de Transporte
('Obligatoria', 'Gestión integral de proyectos de transporte', 1, 3, 18), -- Sistemas de Transporte
('Obligatoria', 'Dirección y operación de terminales', 2, 2, 18), -- Sistemas de Transporte
('Obligatoria', 'Cadena de suministro global', 2, 1, 16), -- Ingenieria Industrial
('Obligatoria', 'Dirección y operación de flotas', 2, 2, 18), -- Sistemas de Transporte
('Obligatoria', 'Modelos de transporte aplicación', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Calidad de servicio en empresas de transporte', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Mercados internacionales', 2, 1, 13); -- Economia

-- Optativas
INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Optativa', 'Ingeniería de operaciones para la cadena de suministro', 2, 1, 16), -- Ingenieria Industrial
('Optativa', 'Implementación de sistemas de gestión para el transporte', 2, 1, 18), -- Sistemas de Transporte
('Optativa', 'Gobierno corporativo', 2, 1, 5), -- Administración
('Optativa', 'Transporte y regionalización económica', 2, 1, 13), -- Economia
('Optativa', 'Economía social y su impacto en el transporte', 2, 1, 13), -- Economia
('Optativa', 'Economía del transporte y sustentabilidad', 2, 1, 13), -- Economia
('Optativa', 'Derecho corporativo en el transporte', 2, 1, 10), -- Derecho
('Optativa', 'Derecho del trabajo en el transporte', 2, 1, 10), -- Derecho
('Optativa', 'Legislación específica para el transporte', 2, 1, 10), -- Derecho
('Optativa', 'Métodos para la demanda', 2, 1, 17), -- Investigacion de Operaciones
('Optativa', 'Administración de la demanda', 2, 1, 17), -- Investigacion de Operaciones
('Optativa', 'Simulación de sistemas para la demanda', 2, 1, 17); -- Investigacion de Operaciones

INSERT INTO Materia (tipo_materia, nom_materia, horas_teoria, horas_prac, id_academia) VALUES
('Obligatoria', 'Introducción a la ingeniería en transporte', 3, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Cálculo diferencial', 3, 1, 1), -- Matemáticas
('Obligatoria', 'Electricidad y magnetismo', 4, 0, 3), -- Física
('Obligatoria', 'Laboratorio de electricidad y magnetismo', 0, 2, 3), -- Física
('Obligatoria', 'Probabilidad y estadística', 3, 1, 1), -- Matemáticas
('Obligatoria', 'Investigación de operaciones', 3, 1, 17), -- Investigación de Operaciones
('Obligatoria', 'Logística y transporte multimodal', 2, 1, 18), -- Sistemas de Transporte
('Obligatoria', 'Seminario de ingeniería en transporte', 2, 2, 18); -- Sistemas de Transporte


-- Semestre 1
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 1, 1, 7, '01'),  -- Matemáticas discretas
(3, 'N', 2, 1, 8, '02'),  -- Fundamentos de física
(3, 'N', 3, 1, 2, '03'),  -- Física general experimental
(3, 'N', 4, 1, 5, '04'),  -- Comunicación profesional interdisciplinaria
(3, 'N', 5, 1, 7, '05'),  -- Fundamentos de administración
(3, 'N', 6, 1, 5, '06'),  -- Responsabilidad social y ética
(3, 'N', 7, 1, 6, '07');  -- Lógica de programación

-- Semestre 2
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 8, 2, 7, '01'),  -- Cálculo diferencial e integral
(3, 'N', 9, 2, 5, '02'),  -- Psicología en el trabajo
(3, 'N', 10, 2, 5, '03'), -- Metodología de la investigación
(3, 'N', 11, 2, 4, '04'), -- Sistemas digitales
(3, 'N', 12, 2, 5, '05'), -- Aplicación de sistemas digitales
(3, 'N', 13, 2, 6, '06'), -- Fundamentos de ingeniería de software
(3, 'N', 14, 2, 6, '07'), -- Estructura de datos
(3, 'N', 15, 2, 6, '08'); -- Programación de bajo nivel

-- Semestre 3
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 16, 3, 7, '01'), -- Probabilidad
(3, 'N', 17, 3, 6, '02'), -- Algoritmos computacionales
(3, 'N', 18, 3, 6, '03'), -- Ingeniería de requerimientos
(3, 'N', 19, 3, 5, '04'), -- Diseño de interfaces de usuario
(3, 'N', 20, 3, 7, '05'), -- Arquitectura y organización de las computadoras
(3, 'N', 21, 3, 6, '06'), -- Construcción de bases de datos
(3, 'N', 22, 3, 6, '07'); -- Programación orientada a objetos

-- Semestre 4
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 23, 4, 7, '01'), -- Estadística
(3, 'N', 24, 4, 5, '02'), -- Dispositivos programables
(3, 'N', 25, 4, 6, '03'), -- Ingeniería de diseño
(3, 'N', 26, 4, 6, '04'), -- Administración de bases de datos
(3, 'N', 27, 4, 6, '05'), -- Seguridad informática
(3, 'N', 28, 4, 7, '06'), -- Sistemas operativos
(3, 'N', 29, 4, 6, '07'); -- Adquisición de datos

-- Semestre 5
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 30, 5, 7, '01'), -- Álgebra lineal
(3, 'N', 31, 5, 7, '02'), -- Métodos numéricos
(3, 'N', 32, 5, 7, '03'), -- Contabilidad financiera y de costos
(3, 'N', 33, 5, 7, '04'), -- Aplicación de la ciencia económica
(3, 'N', 34, 5, 7, '05'), -- Teoría de la computación y compiladores
(3, 'N', 35, 5, 7, '06'), -- Comunicación de datos
(3, 'N', 36, 5, 6, '07'); -- Programación WEB

-- Semestre 6 
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 37, 6, 7, '01'), -- Modelos determinísticos de investigación de operaciones
(3, 'N', 38, 6, 5, '02'), -- Ingeniería económica
(3, 'N', 39, 6, 7, '03'), -- Presupuesto y finanzas
(3, 'N', 40, 6, 7, '04'), -- Redes y conectividad
(3, 'N', 41, 6, 7, '05'), -- Fundamentos de inteligencia artificial
(3, 'N', 42, 6, 6, '06'), -- Ingeniería de pruebas
(3, 'N', 43, 6, 6, '07'); -- Programación móvil

-- Semestre 7
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 44, 7, 7, '01'), -- Redes y modelos de simulación
(3, 'N', 45, 7, 6, '02'), -- Administración estratégica
(3, 'N', 46, 7, 7, '03'), -- Legislación informática
(3, 'N', 47, 7, 5, '04'), -- Formulación y evaluación de proyectos
(3, 'N', 48, 7, 6, '05'), -- Ingeniería del conocimiento
(3, 'N', 49, 7, 6, '06'), -- Internet de las cosas
(3, 'N', 50, 7, 7, '07'); -- Seguridad en redes

-- Semestre 8
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 51, 8, 4, '01'), -- Habilidades directivas
(3, 'N', 52, 8, 5, '02'), -- Informática empresarial
(3, 'N', 53, 8, 3, '03'), -- Proyecto de titulación
(3, 'N', 54, 8, 5, '04'), -- Gestión de proyectos
(3, 'N', 55, 8, 6, '05'), -- Calidad y normalización de software
(3, 'N', 56, 8, 6, '06'), -- Administración de tecnologías
(3, 'N', 57, 8, 6, '07'), -- Fundamentos de analítica de datos
(3, 'N', 58, 8, 6, '08'); -- Computación en la nube

-- Optativas informática
-- Optativas Semestre 5
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 59, 5, 5, '08'),  -- Hackeo ético
(3, 'N', 62, 5, 5, '09'),  -- Escenarios virtuales
(3, 'N', 65, 5, 5, '10');  -- Sistemas embebidos

-- Optativas Semestre 6
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 60, 6, 5, '08'),  -- Virología y criptografía
(3, 'N', 63, 6, 5, '09'),  -- Ambientes virtuales inmersivos
(3, 'N', 66, 6, 5, '10');  -- Informática en ambientes productivos

-- Optativas Semestre 7
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(3, 'N', 61, 7, 5, '08'),  -- Monitoreo y administración de redes
(3, 'N', 64, 7, 5, '09'),  -- Simuladores virtuales
(3, 'N', 67, 7, 5, '10');  -- Big data y toma de decisiones

-- Mapa Curricular Ingenieria Industrial
-- Ingeniería Industrial, Plan 2022 (id_plan = 7)

-- Semestre 1
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 193, 1, 6, '01'),-- Calculo diferencial
(7, 'I', 68, 1, 7, '02'),-- Cálculo vectorial
(7, 'I', 69, 1, 4, '03'),-- Dibujo industrial asistido por computadora
(7, 'I', 70, 1, 5, '04'), -- Tecnologia informática
(7, 'I', 5, 1, 7, '05'), -- Fundamentos de administración
(7, 'I', 10, 1, 5, '06'), -- Metodología de la investigación
(7, 'I', 6, 1, 5, '07'); -- Responsabilidad social y ética

-- Semestre 2
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 71, 2, 8, '01'), -- Mecánica clasica
(7, 'I', 72, 2, 2, '02'), -- Laboratorio de mecánica clásica
(7, 'I', 8, 2, 7, '03'), -- Cálculo integral
(7, 'I', 73, 2, 5, '04'), -- Administración de capital humano
(7, 'I', 74, 2, 7, '05'), -- Legislación industrial
(7, 'I', 75, 2, 5, '06'), -- Comunicación profesional
(7, 'I', 9, 2, 5, '07'), -- Psicología en el trabajo
(7, 'I', 16, 2, 7, '08'); -- Probabilidad

-- Semestre 3
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 23, 3, 7, '01'), -- Estadística
(7, 'I', 76, 3, 8, '02'), -- Electromagnetismo
(7, 'I', 77, 3, 2, '03'), -- Laboratorio de electromagnetismo
(7, 'I', 78, 3, 7, '04'), -- Métodos matemáticos
(7, 'I', 79, 3, 8, '05'), -- Quimica aplicada
(7, 'I', 80, 3, 2, '06'), -- Laboratorio de química aplicada
(7, 'I', 33, 3, 7, '07'), -- Economia
(7, 'I', 81, 3, 5, '08'), -- Mecánica de materiales
(7, 'I', 82, 3, 2, '09'), -- Diseño y evaluación de estándares de trabajo
(7, 'I', 83, 3, 6, '10'); -- Productividad y diseño del trabajo

-- Semestre 4
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 84, 4, 4, '01'), -- Nonnalización y metrologia dimensional
(7, 'I', 30, 4, 7, '02'), -- Álgebra lineal
(7, 'I', 85, 4, 5, '03'), -- Dinamica de mecanismos
(7, 'I', 86, 4, 8, '04'), -- Quimica industrial
(7, 'I', 87, 4, 2, '05'), -- Laboratorio de quimica industrial
(7, 'I', 88, 4, 6, '06'), -- Electricidad y electrónica
(7, 'I', 89, 4, 6, '07'), -- Tecnologia de materiales
(7, 'I', 90, 4, 4, '08'), -- Sistemas neumáticos hidráulicos
(7, 'I', 32, 4, 7, '09'); -- Contabilidad y costos

-- Semestre 5
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 91, 5, 6, '01'), -- Plantas y procesos industriales
(7, 'I', 92, 5, 3, '02'), -- Electricidad aplicada
(7, 'I', 93, 5, 6, '03'), -- Determinación y aplicación de estandares
(7, 'I', 94, 5, 3, '04'), -- Ingenieria de estandares
(7, 'I', 95, 5, 4, '05'), -- Pruebas de control de calidad
(7, 'I', 37, 5, 7, '06'), -- Modelos determinísticos de investigación de operaciones
(7, 'I', 96, 5, 6, '07'), -- instrumentación y control
(7, 'I', 97, 5, 7, '08'), -- Planeación financiera
(7, 'I', 98, 5, 7, '09'), -- Mercadotecnia
(7, 'I', 99, 5, 7, '10'); -- Planeación y control de inventarios

-- Semestre 6
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 100, 6, 7, '01'), -- Modelos estocásticos de investigación de operaciones
(7, 'I', 38, 6, 5, '02'), -- Ingeniería económica
(7, 'I', 101, 6, 7, '03'), -- Planeación y control maestro de la producción
(7, 'I', 102, 6, 3, '04'), -- Conformado de materiales
(7, 'I', 103, 6, 5, '05'), -- Manufactura esbelta
(7, 'I', 104, 6, 7, '06'), -- Distribución de planta y manejo de materiales
(7, 'I', 45, 6, 6, '07'), -- Administración estratégica
(7, 'I', 105, 6, 3, '08'), -- Sistemas hibridos
(7, 'I', 106, 6, 5, '09'); -- Manufactura integral

-- Semestre 7
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 107, 7, 3, '01'), -- Mecanizado industrial
(7, 'I', 108, 7, 4, '02'), -- Manufactura aditiva y sustractiva
(7, 'I', 47, 7, 5, '03'), -- Formulación y evaluación de proyectos
(7, 'I', 109, 7, 7, '04'), -- Mantenimiento
(7, 'I', 110, 7, 7, '05'), -- Seguridad y salud en el trabajo
(7, 'I', 111, 7, 5, '06'), -- Logistica
(7, 'I', 112, 7, 7, '07'), -- Simulación de sistemas
(7, 'I', 113, 7, 5, '08'); -- Gestión de la innovación

-- Semestre 8
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 114, 8, 5, '01'), -- Gestión de la cadena de suministro
(7, 'I', 115, 8, 7, '02'), -- Gestión ambiental
(7, 'I', 116, 8, 6, '03'), -- Sistemas integrados de manufactura
(7, 'I', 54, 8, 5, '04'), -- Gestión de proyectos
(7, 'I', 118, 8, 4, '05'), -- Emprendimiento
(7, 'I', 119, 8, 4, '06'), -- Sistemas de gestión de calidad
(7, 'I', 120, 8, 4, '07'); -- Habilidades directivas

-- Optativas 6to Semestre
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 121, 6, 4, '10'),
(7, 'I', 124, 6, 4, '11'),  -- Seguridad en el trabajo
(7, 'I', 127, 6, 4, '12'),  -- Ingeniería de operaciones
(7, 'I', 130, 6, 4, '13');  -- Tecnologias inteligentes

-- Semestre 7
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 122, 7, 4, '09'),  -- Desarrollo del producto
(7, 'I', 125, 7, 4, '10'),  -- Salud en el trabajo
(7, 'I', 128, 7, 4, '11'),  -- Solución a problemas de la alta dirección
(7, 'I', 131, 7, 4, '12');  -- Integración de las tecnologías en la industria 5.0

-- Semestre 8
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(7, 'I', 123, 8, 4, '08'),  -- Planificación avanzada de la calidad del producto
(7, 'I', 126, 8, 4, '09'),  -- Gestión de riesgo y protección civil
(7, 'I', 129, 8, 4, '10'),  -- Implementación de sistemas de gestión
(7, 'I', 132, 8, 4, '11');  -- Comercialización internacional y digital

-- Ingeniería en Transporte, Plan 2020 (id_plan = 5)

-- Semestre 1
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(5, 'T', 133, 1, 8, '01'), -- Fundamentos matemáticos
(5, 'T', 134, 1, 6, '02'), -- Elementos del cálculo vectorial
(5, 'T', 135, 1, 5, '03'), -- Dibujo asistido por computadora
(5, 'T', 136, 1, 7, '04'), -- Sistemas y la ingenieria en transporte
(5, 'T', 137, 1, 5, '05'), -- Metodologia de la ingenieria
(5, 'T', 4, 1, 5, '06'), -- Comunicación profesional interdisciplinaria
(5, 'T', 192, 1, 4, '07'); -- Introducción a la ingeniería en transporte

-- Semestre 2
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(5, 'T', 72, 2, 8, '01'), -- Mecánica clasica
(5, 'T', 73, 2, 2, '02'), -- Laboratorio de mecánica clásica
(5, 'T', 193, 2, 8, '03'), -- Cálculo diferencial
(5, 'T', 141, 2, 5, '04'), -- Proyecto de vias terrestres
(5, 'T', 142, 2, 5, '05'), -- Sistemas de información geográfica
(5, 'T', 143, 2, 5, '06'), -- Sistema de transporte carretero
(5, 'T', 144, 2, 5, '07'); -- Sistema de transporte ferroviario

-- Semestre 3
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(5, 'T', 145, 3, 8, '01'), -- Química energética y ambiental
(5, 'T', 146, 3, 2, '02'), -- Laboratorio de química energética y ambiental
(5, 'T', 16, 3, 7, '03'), -- Probabilidad
(5, 'T', 147, 3, 5, '04'), -- Sistema de transporte marítimo
(5, 'T', 148, 3, 5, '05'), -- Sistema de transporte aéreo
(5, 'T', 149, 3, 5, '06'), -- Programación y bases de datos
(5, 'T', 194, 3, 8, '07'), -- Electricidad y magnetismo
(5, 'T', 195, 3, 2, '08'); -- Laboratorio de electricidad y magnetismo

-- Semestre 4
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(5, 'T', 150, 4, 7, '01'), -- Tecnología de vehículos y laboratorios
(5, 'T', 23, 4, 7, '02'), -- Estadística
(5, 'T', 151, 4, 7, '03'), -- Sistema de transporte multimodal
(5, 'T', 152, 4, 7, '04'), -- Ingeniería de tránsito
(5, 'T', 153, 4, 7, '05'), -- Legislación para el transporte
(5, 'T', 154, 4, 5, '06'), -- Tecnología aplicada al transporte
(5, 'T', 196, 4, 7, '07'); -- Probabilidad y estadística

-- Semestre 5
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(5, 'T', 155, 5, 7, '01'), -- Matemáticas aplicadas
(5, 'T', 156, 5, 7, '02'), -- Estadística aplicada
(5, 'T', 30, 5, 7, '03'), -- Álgebra lineal
(5, 'T', 157, 5, 5, '04'), -- Administración estratégica para el transporte
(5, 'T', 158, 5, 5, '05'), -- Gestión y seguridad de pasajeros y carga
(5, 'T', 159, 5, 7, '06'), -- Cadena de suministro de proceso
(5, 'T', 31, 5, 7, '07'); -- Métodos numéricos

-- Semestre 6
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(5, 'T', 160, 6, 7, '01'), -- Macroeconomía
(5, 'T', 161, 6, 7, '02'), -- Capital humano en empresas de transporte
(5, 'T', 38, 6, 5, '03'), -- Ingeniería económica
(5, 'T', 162, 6, 5, '04'), -- Ingeniería en transporte terrestre
(5, 'T', 163, 6, 5, '05'), -- Planeación del transporte
(5, 'T', 164, 6, 5, '06'), -- Cadena de suministro, almacenes e inventarios
(5, 'T', 165, 6, 7, '07'), -- Economía de la ingeniería
(5, 'T', 197, 6, 7, '08'); -- Investigación de operaciones

-- Semestre 7
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(5, 'T', 166, 7, 5, '01'), -- Modelos de reemplazo y mantenimiento
(5, 'T', 47, 7, 5, '02'), -- Formulación y evaluación de proyectos
(5, 'T', 167, 7, 5, '03'), -- Ingeniería en transporte aéreo
(5, 'T', 168, 7, 5, '04'), -- Ingeniería en transporte marítimo
(5, 'T', 169, 7, 5, '05'), -- Cadena de suministro diseño de red
(5, 'T', 170, 7, 5, '06'), -- Seguridad integral del transporte
(5, 'T', 171, 7, 5, '07'), -- Modelos de transporte
(5, 'T', 198, 7, 5, '08'); -- Logística y transporte multimodal

-- Semestre 8
INSERT INTO Mapa_Curricular (id_plan, abr_carr, id_materia, semestre, creditos, no_materia) VALUES
(5, 'T', 172, 8, 5, '01'), -- Proyecto de titulación
(5, 'T', 173, 8, 5, '02'), -- Gestión integral de proyectos de transporte
(5, 'T', 174, 8, 6, '03'), -- Dirección y operación de terminales
(5, 'T', 175, 8, 5, '04'), -- Cadena de suministro global
(5, 'T', 176, 8, 6, '05'), -- Dirección y operación de flotas
(5, 'T', 177, 8, 5, '06'), -- Modelos de transporte aplicación
(5, 'T', 178, 8, 5, '07'), -- Calidad de servicio en empresas de transporte
(5, 'T', 179, 8, 5, '08'), -- Mercados internacionales
(5, 'T', 199, 8, 4, '09'); -- Seminario de ingeniería en transporte