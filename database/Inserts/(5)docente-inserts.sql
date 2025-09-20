USE db_escolar;

INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(1, 'Juan', 'Pérez', 'García', 'PGAJ850101A45', 'juan.perez@example.com', 'jperez@ipn.mx', '5551234567', 'Av. de los Maestros', '100', 'A', 'Lindavista', 'Gustavo A. Madero', 77520),
(2, 'María', 'López', 'Martínez', 'LMMR860202B56', 'maria.lopez@example.com', 'mlopez@ipn.mx', '5552345678', 'Calz. de Guadalupe', '250', '2', 'Industrial', 'Gustavo A. Madero', 77000),
(3, 'Carlos', 'Sánchez', 'Hernández', 'SHCJ870303C67', 'carlos.sanchez@example.com', 'csanchez@ipn.mx', '5553456789', 'Av. Instituto Politécnico Nacional', '500', '1', 'Zacatenco', 'Gustavo A. Madero', 77380),
(4, 'Ana', 'Rodríguez', 'Núñez', 'RANC880404D78', 'ana.rodriguez@example.com', 'arodriguez@ipn.mx', '5554567890', 'Calle de la Reforma', '10', '3', 'Polanco', 'Miguel Hidalgo', 11560),
(5, 'Luis', 'Fernández', 'Ramos', 'FRLJ890505E89', 'luis.fernandez@example.com', 'lfernandez@ipn.mx', '5555678901', 'Av. Insurgentes Sur', '1500', '4', 'Roma Sur', 'Cuauhtémoc', 6760),
(6, 'Sofía', 'Gómez', 'Vázquez', 'GVSM900606F90', 'sofia.gomez@example.com', 'sgomez@ipn.mx', '5556789012', 'Eje Central Lázaro Cárdenas', '50', '5', 'Centro Histórico', 'Cuauhtémoc', 6000),
(7, 'José', 'Martínez', 'Ruiz', 'MRJH910707G01', 'jose.martinez@example.com', 'jmartinez@ipn.mx', '5557890123', 'Av. Universidad', '1000', '6', 'Del Valle', 'Benito Juárez', 3100),
(8, 'Laura', 'Hernández', 'González', 'HGLA920808H12', 'laura.hernandez@example.com', 'lhernandez@ipn.mx', '5558901234', 'Calz. de Tlalpan', '3000', '7', 'Villa Olímpica', 'Tlalpan', 14020),
(1, 'Andrés', 'Mendoza', 'Soto', 'MSA930101H23', 'andres.mendoza@example.com', 'amendoza@ipn.mx', '5559012345', 'Av. División del Norte', '2000', '8', 'Del Carmen', 'Coyoacán', 4100),
(2, 'Clara', 'Ramírez', 'Ortiz', 'ROC940202I34', 'clara.ramirez@example.com', 'cramirez@ipn.mx', '5550123456', 'Eje 10 Sur', '100', '9', 'Portales', 'Benito Juárez', 3300),
(3, 'Esteban', 'Morales', 'Domínguez', 'MED950303J45', 'esteban.morales@example.com', 'emorales@ipn.mx', '5551234567', 'Av. Revolución', '500', '10', 'San Pedro de los Pinos', 'Benito Juárez', 1180),
(4, 'Gabriela', 'Pérez', 'Guzmán', 'PGG960404K56', 'gabriela.perez@example.com', 'gperez@ipn.mx', '5552345678', 'Circuito Interior', '100', '11', 'Condesa', 'Cuauhtémoc', 6140),
(5, 'Hugo', 'Jiménez', 'Serrano', 'JSH970505L67', 'hugo.jimenez@example.com', 'hjimenez@ipn.mx', '5553456789', 'Av. Paseo de la Reforma', '400', '12', 'Juárez', 'Cuauhtémoc', 6600),
(6, 'Isabel', 'Díaz', 'Romero', 'DIR980606M78', 'isabel.diaz@example.com', 'idiaz@ipn.mx', '5554567890', 'Calz. México-Tacuba', '200', '13', 'Tacuba', 'Miguel Hidalgo', 11410),
(7, 'Javier', 'Martínez', 'Mendoza', 'MMM990707N89', 'javier.martinez@example.com', 'jmartinez2@ipn.mx', '5555678901', 'Av. Constituyentes', '500', '14', 'Lomas Altas', 'Miguel Hidalgo', 11950),
(8, 'Karen', 'Flores', 'Torres', 'FTK000808O90', 'karen.flores@example.com', 'kflores@ipn.mx', '5556789012', 'Periférico Sur', '4000', '15', 'Jardines del Pedregal', 'Álvaro Obregón', 1070),
(1, 'Lorenzo', 'Ruiz', 'Cruz', 'RCL010909P01', 'lorenzo.ruiz@example.com', 'lruiz@ipn.mx', '5557890123', 'Av. Aztecas', '200', '16', 'Ajusco', 'Coyoacán', 4300),
(2, 'Pedro', 'Gutiérrez', 'López', 'GGLP021010Q12', 'pedro.gutierrez@example.com', 'pg@ipn.mx', '5558901234', 'Calz. Ermita Iztapalapa', '1500', '17', 'Santa María Aztahuacan', 'Iztapalapa', 9500),
(2, 'Alejandra', 'Hernández', 'García', 'HHAG031111R23', 'alejandra.hernandez@example.com', 'ah@ipn.mx', '5559012345', 'Av. Tláhuac', '1000', '18', 'Los Olivos', 'Tláhuac', 13210),
(2, 'Roberto', 'López', 'Martínez', 'LLRM041212S34', 'roberto.lopez@example.com', 'rl@ipn.mx', '5550123456', 'Eje 6 Sur', '200', '19', 'Independencia', 'Benito Juárez', 3600),
(2, 'Diana', 'Flores', 'Pérez', 'FFDP050113T45', 'diana.flores@example.com', 'df@ipn.mx', '5551234567', 'Av. Cuauhtémoc', '500', '20', 'Doctores', 'Cuauhtémoc', 6700),
(2, 'Elena', 'Gómez', 'Fernández', 'GOFE910909A12', 'elena.gomez@example.com', 'egomez@ipn.mx', '5551234567', 'Av. Revolución', '1200', '5', 'Tacubaya', 'Miguel Hidalgo', 11870),
(2, 'Raúl', 'Jiménez', 'Sánchez', 'JISR921010B23', 'raul.jimenez@example.com', 'rjimenez@ipn.mx', '5552345678', 'Calz. México-Tacuba', '800', '1', 'Popotla', 'Miguel Hidalgo', 11400),
(2, 'Fernanda', 'Díaz', 'Ramírez', 'DIRF931111C34', 'fernanda.diaz@example.com', 'fdiaz@ipn.mx', '5553456789', 'Av. Marina Nacional', '350', '2', 'Anáhuac', 'Miguel Hidalgo', 11320),
(2, 'Omar', 'Martínez', 'Morales', 'MMOR941212D45', 'omar.martinez@example.com', 'omartinez@ipn.mx', '5554567890', 'Lago Alberto', '365', '3', 'Polanco', 'Miguel Hidalgo', 11550),
(2, 'Brenda', 'Flores', 'Domínguez', 'FLDO950113E56', 'brenda.flores@example.com', 'bflores@ipn.mx', '5555678901', 'Ejercito Nacional', '840', '4', 'Granada', 'Miguel Hidalgo', 11520),
(4, 'Guillermo', 'Ruiz', 'Cruz', 'RUCR960214F67', 'guillermo.ruiz@example.com', 'gruiz@ipn.mx', '5556789012', 'Av. Universidad', '1800', '1', 'Copilco Universidad', 'Coyoacán', 4310),
(4, 'Patricia', 'Gutiérrez', 'López', 'GULP970315G78', 'patricia.gutierrez@example.com', 'pgutierrez@ipn.mx', '5557890123', 'Miguel Ángel de Quevedo', '610', '2', 'Coyoacán Centro', 'Coyoacán', 4000),
(4, 'Héctor', 'Hernández', 'García', 'HEGA980416H89', 'hector.hernandez@example.com', 'hhernandez@ipn.mx', '5558901234', 'Calz. de Tlalpan', '4800', '3', 'Huipulco', 'Tlalpan', 14370),
(4, 'Lucía', 'López', 'Martínez', 'LOMA990517I90', 'lucia.lopez@example.com', 'llopez@ipn.mx', '5559012345', 'División del Norte', '3200', '4', 'Xotepingo', 'Coyoacán', 4110),
(4, 'Daniel', 'Flores', 'Pérez', 'FLPE000618J01', 'daniel.flores@example.com', 'dflores@ipn.mx', '5550123456', 'Av. Pacífico', '240', '5', 'La Concepción', 'Coyoacán', 4020),(2, 'Mario', 'Andrade', 'Lozano', 'ANLM870619A78', 'mario.andrade@example.com', 'mandrade@ipn.mx', '5551234567', 'Av. de las Torres', '800', '1', 'Campestre Churubusco', 'Coyoacán', 4200),
(4, 'Karla', 'Salazar', 'Vargas', 'SAVK880720B89', 'karla.salazar@example.com', 'ksalazar@ipn.mx', '5552345678', 'Calz. del Hueso', '300', '2', 'Ex Hacienda Coapa', 'Tlalpan', 14390),
(2, 'Jorge', 'Vega', 'Molina', 'VEMO890821C90', 'jorge.vega@example.com', 'jvega@ipn.mx', '5553456789', 'Canal de Miramontes', '1500', '3', 'Narciso Mendoza', 'Tlalpan', 14380),
(4, 'Adriana', 'Ríos', 'Franco', 'RIAF900922D01', 'adriana.rios@example.com', 'arios@ipn.mx', '5554567890', 'Av. Insurgentes Sur', '2000', '4', 'Chimalistac', 'Álvaro Obregón', 10700),
(1, 'Miguel', 'Ramirez', 'Garcia', 'RGMG911023A12', 'miguel.ramirez@example.com', 'mramirez@ipn.mx', '5551234567', 'Av. de los Insurgentes', '100', 'A', 'Lindavista', 'Gustavo A. Madero', 77520),
(1, 'Sofia', 'Lopez', 'Hernandez', 'LOHS921124B23', 'sofia.lopez@example.com', 'slopez@ipn.mx', '5552345678', 'Calz. de las Aguilas', '250', '2', 'Industrial', 'Gustavo A. Madero', 77000),
(1, 'Ricardo', 'Sanchez', 'Martinez', 'SAMR931225C34', 'ricardo.sanchez@example.com', 'rsanchez@ipn.mx', '5553456789', 'Eje Central', '500', '1', 'Zacatenco', 'Gustavo A. Madero', 77380),
(5, 'Valeria', 'Gomez', 'Vazquez', 'GOVL940126D45', 'valeria.gomez@example.com', 'vgomez@ipn.mx', '5554567890', 'Av. Revolucion', '10', '3', 'Polanco', 'Miguel Hidalgo', 11560),
(5, 'Javier', 'Torres', 'Perez', 'TOJV950227E56', 'javier.torres@example.com', 'jtorres@ipn.mx', '5555678901', 'Periferico Sur', '1500', '4', 'Roma Sur', 'Cuauhtemoc', 6760),
(5, 'Brenda', 'Flores', 'Gonzalez', 'FLBR960328F67', 'brenda.flores@example.com', 'bflores@ipn.mx', '5556789012', 'Calz. Ermita Iztapalapa', '50', '5', 'Centro Historico', 'Cuauhtemoc', 6000),
(6, 'Esteban', 'Ruiz', 'Cruz', 'RUES970429G78', 'esteban.ruiz@example.com', 'eruiz@ipn.mx', '5557890123', 'Av. Tlahuac', '1000', '6', 'Del Valle', 'Benito Juarez', 3100),
(6, 'Ana', 'Diaz', 'Romero', 'DIAN980530H89', 'ana.diaz@example.com', 'adiaz@ipn.mx', '5558901234', 'Eje 6 Sur', '3000', '7', 'Villa Olimpica', 'Tlalpan', 14020),
(6, 'Luis', 'Mendoza', 'Soto', 'MELU990631I90', 'luis.mendoza@example.com', 'lmendoza@ipn.mx', '5559012345', 'Av. Cuauhtemoc', '2000', '8', 'Del Carmen', 'Coyoacan', 4100);

-- Academia: Química (9)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(9, 'Eduardo', 'Campos', 'Lara', 'CALE850510Q23', 'eduardo.campos@example.com', 'ecampos@ipn.mx', '5551122334', 'Calle del Río', '15', '3', 'Jardines del Sur', 'Xochimilco', 16050),
(9, 'Carolina', 'Soto', 'Miranda', 'SOMI860621R34', 'carolina.soto@example.com', 'csoto@ipn.mx', '5552233445', 'Av. de la Paz', '22', '1', 'San Ángel', 'Álvaro Obregón', 01000),
(9, 'Roberto', 'Fuentes', 'Ortega', 'FUOR870702S45', 'roberto.fuentes@example.com', 'rfuentes@ipn.mx', '5553344556', 'Francisco Sosa', '120', 'A', 'Coyoacán', 'Coyoacán', 04000),
(9, 'Mariana', 'Ibarra', 'Esquivel', 'IBEM880813T56', 'mariana.ibarra@example.com', 'mibarra@ipn.mx', '5554455667', 'Av. México', '55', '2', 'Hipódromo Condesa', 'Cuauhtémoc', 06170),
(9, 'Oscar', 'Zamora', 'Pineda', 'ZAPI890924U67', 'oscar.zamora@example.com', 'ozamora@ipn.mx', '5555566778', 'Ámsterdam', '210', 'B', 'Condesa', 'Cuauhtémoc', 06100);

-- Academia: Derecho (10)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(10, 'Fernanda', 'Rojas', 'Aguilar', 'ROAF901005V78', 'fernanda.rojas@example.com', 'frojas@ipn.mx', '5556677889', 'Durango', '75', '4', 'Roma Norte', 'Cuauhtémoc', 06700),
(10, 'Ricardo', 'Molina', 'Solís', 'MOSR911116W89', 'ricardo.molina@example.com', 'rmolina@ipn.mx', '5557788990', 'Marsella', '30', '1', 'Juárez', 'Cuauhtémoc', 06600),
(10, 'Liliana', 'Vargas', 'Reyes', 'VARL921227X90', 'liliana.vargas@example.com', 'lvargas@ipn.mx', '5558899001', 'Liverpool', '95', 'A', 'Juárez', 'Cuauhtémoc', 06600),
(10, 'Carlos', 'Uribe', 'Ochoa', 'URCO930108Y01', 'carlos.uribe@example.com', 'curibe@ipn.mx', '5559900112', 'Amberes', '60', '2', 'Juárez', 'Cuauhtémoc', 06600),
(10, 'Andrea', 'Nava', 'Jiménez', 'NAJA940219Z12', 'andrea.nava@example.com', 'anava@ipn.mx', '5550011223', 'Florencia', '45', '3', 'Juárez', 'Cuauhtémoc', 06600);

-- Academia: Finanzas (11)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(11, 'Diego', 'Luna', 'Pacheco', 'LUPD850310A23', 'diego.luna@example.com', 'dluna@ipn.mx', '5551122334', 'Paseo de la Reforma', '265', '10', 'Juárez', 'Cuauhtémoc', 06600),
(11, 'Valentina', 'Silva', 'Mendoza', 'SIMV860421B34', 'valentina.silva@example.com', 'vsilva@ipn.mx', '5552233445', 'Insurgentes Sur', '1605', '5', 'San José Insurgentes', 'Benito Juárez', 03900),
(11, 'Alejandro', 'Cortés', 'Ríos', 'CORA870502C45', 'alejandro.cortes@example.com', 'acortes@ipn.mx', '5553344556', 'Río Churubusco', '420', '2', 'Del Carmen', 'Coyoacán', 04100),
(11, 'Isabella', 'Guerrero', 'Chávez', 'GUC880613D56', 'isabella.guerrero@example.com', 'iguerrero@ipn.mx', '5554455667', 'Félix Cuevas', '366', '3', 'Tlacoquemécatl', 'Benito Juárez', 03200),
(11, 'Samuel', 'Orozco', 'Torres', 'ORTS890724E67', 'samuel.orozco@example.com', 'sorozco@ipn.mx', '5555566778', 'Patriotismo', '201', '4', 'San Pedro de los Pinos', 'Benito Juárez', 03800);

-- Academia: Mercadotecnia y Recursos Humanos (12)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(12, 'Camila', 'Reyes', 'Corona', 'RECO900805F78', 'camila.reyes@example.com', 'creyes@ipn.mx', '5556677889', 'Tamaulipas', '150', '6', 'Condesa', 'Cuauhtémoc', 06140),
(12, 'Mateo', 'Santos', 'Gómez', 'SAGM910916G89', 'mateo.santos@example.com', 'msantos@ipn.mx', '5557788990', 'Álvaro Obregón', '286', '1', 'Roma Norte', 'Cuauhtémoc', 06700),
(12, 'Renata', 'Morales', 'Luna', 'MOLR921027H90', 'renata.morales@example.com', 'rmorales@ipn.mx', '5558899001', 'Michoacán', '90', '2', 'Condesa', 'Cuauhtémoc', 06140),
(12, 'Joaquín', 'Aguilar', 'Vargas', 'AGVJ931108I01', 'joaquin.aguilar@example.com', 'jaguilar@ipn.mx', '5559900112', 'Nuevo León', '238', '3', 'Hipódromo', 'Cuauhtémoc', 06100),
(12, 'Ximena', 'Cordero', 'Rojas', 'CORX941219J12', 'ximena.cordero@example.com', 'xcoro@ipn.mx', '5559900112', 'Nuevo León', '238', '3', 'Hipódromo', 'Cuauhtémoc', 06100);

-- Academia: Economía (13)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(13, 'Emilio', 'Olivares', 'Castro', 'OICE950310K23', 'emilio.olivares@example.com', 'eolivares@ipn.mx', '5550011223', 'Horacio', '1856', '4', 'Polanco', 'Miguel Hidalgo', 11550),
(13, 'Valeria', 'Peña', 'Nieto', 'PENV960421L34', 'valeria.pena@example.com', 'vpena@ipn.mx', '5551122334', 'Masaryk', '29', '5', 'Polanco', 'Miguel Hidalgo', 11560),
(13, 'Santiago', 'García', 'Salgado', 'GASS970502M45', 'santiago.garcia@example.com', 'sgarcia@ipn.mx', '5552233445', 'Campos Elíseos', '345', '6', 'Polanco', 'Miguel Hidalgo', 11550),
(13, 'Luciana', 'Herrera', 'Márquez', 'HEML980613N56', 'luciana.herrera@example.com', 'lherrera@ipn.mx', '5553344556', 'Arquímedes', '130', '7', 'Polanco', 'Miguel Hidalgo', 11550),
(13, 'Daniel', 'Mendoza', 'Vásquez', 'MEVD990724O67', 'daniel.mendoza@example.com', 'dmendoza@ipn.mx', '5554455667', 'Newton', '186', '8', 'Polanco', 'Miguel Hidalgo', 11550);

-- Academia: Tecnología Informática (14)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(14, 'Miranda', 'Sánchez', 'Pérez', 'SAPM900805P78', 'miranda.sanchez@example.com', 'msanchez@ipn.mx', '5555566778', 'Homero', '1330', '1', 'Polanco', 'Miguel Hidalgo', 11550),
(14, 'Sebastián', 'Ríos', 'González', 'RIGS910916Q89', 'sebastian.rios@example.com', 'srios@ipn.mx', '5556677889', 'Sudermann', '250', '2', 'Polanco', 'Miguel Hidalgo', 11550),
(14, 'Regina', 'Ortiz', 'Cruz', 'ORCR921027R90', 'regina.ortiz@example.com', 'rortiz@ipn.mx', '5557788990', 'Tennyson', '79', '3', 'Polanco', 'Miguel Hidalgo', 11550),
(14, 'Leonardo', 'Castro', 'Soto', 'CASL931108S01', 'leonardo.castro@example.com', 'lcastro@ipn.mx', '5558899001', 'Lope de Vega', '342', '4', 'Polanco', 'Miguel Hidalgo', 11550),
(14, 'Paulina', 'Duarte', 'Jiménez', 'DUJP941219T12', 'paulina.duarte@example.com', 'pduarte@ipn.mx', '5559900112', 'Ejército Nacional', '453', '5', 'Granada', 'Miguel Hidalgo', 11520);

-- Academia: Ingeniería Industrial (16)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(16, 'Francisco', 'Villa', 'Dorantes', 'VIDF850310U23', 'francisco.villa@example.com', 'fvilla@ipn.mx', '5550011223', 'Río San Joaquín', '498', '1', 'Ampliación Granada', 'Miguel Hidalgo', 11529),
(16, 'Catalina', 'López', 'Roldán', 'LORC860421V34', 'catalina.lopez@example.com', 'clopez@ipn.mx', '5551122334', 'Cervantes Saavedra', '301', '2', 'Granada', 'Miguel Hidalgo', 11520),
(16, 'Manuel', 'Chávez', 'Treviño', 'CHTM870502W45', 'manuel.chavez@example.com', 'mchavez@ipn.mx', '5552233445', 'Lago Alberto', '320', '3', 'Anáhuac I Sección', 'Miguel Hidalgo', 11320),
(16, 'Elisa', 'Fuentes', 'Salinas', 'FUSE880613X56', 'elisa.fuentes@example.com', 'efuentes@ipn.mx', '5553344556', 'Ferrocarril de Cuernavaca', '510', '4', 'Anáhuac II Sección', 'Miguel Hidalgo', 11320),
(16, 'Arturo', 'Ocampo', 'Ponce', 'OAPA890724Y67', 'arturo.ocampo@example.com', 'aocampo@ipn.mx', '5554455667', 'Presa Falcón', '17', '5', 'Irrigación', 'Miguel Hidalgo', 11500);

-- Academia: Investigación de Operaciones (17)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(17, 'Julia', 'Vargas', 'Domínguez', 'VADJ900805Z78', 'julia.vargas@example.com', 'jvargas@ipn.mx', '5555566778', 'Bahía de la Ascensión', '31', '6', 'Verónica Anzures', 'Miguel Hidalgo', 11300),
(17, 'Gabriel', 'Romero', 'Espinoza', 'ROEG910916A89', 'gabriel.romero@example.com', 'gromero@ipn.mx', '5556677889', 'Bahía de Ballenas', '74', '1', 'Verónica Anzures', 'Miguel Hidalgo', 11300),
-- Academia: Investigación de Operaciones (17)
(17, 'Rodrigo', 'Mendez', 'Aguilar', 'MEAR931108C01', 'rodrigo.mendez@example.com', 'rmendez@ipn.mx', '5558899001', 'Laguna de Términos', '221', '3', 'Anáhuac I Sección', 'Miguel Hidalgo', 11320),
(17, 'Mariana', 'Solis', 'Herrera', 'SOHM941219D12', 'mariana.solis@example.com', 'msolis@ipn.mx', '5559900112', 'Lago Como', '67', '4', 'Anáhuac II Sección', 'Miguel Hidalgo', 11320);

-- Academia: Sistemas de Transporte (18)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(18, 'Armando', 'Torres', 'Salinas', 'TOSA850310E23', 'armando.torres@example.com', 'atorres@ipn.mx', '5550011223', 'Lago Xochimilco', '145', '1', 'Anáhuac I Sección', 'Miguel Hidalgo', 11320),
(18, 'Isabel', 'Rojas', 'Mendoza', 'ROMI860421F34', 'isabel.rojas@example.com', 'irojas@ipn.mx', '5551122334', 'Lago Zirahuén', '88', '2', 'Anáhuac II Sección', 'Miguel Hidalgo', 11320),
(18, 'Jorge', 'Pérez', 'Lugo', 'PELJ870502G45', 'jorge.perez@example.com', 'jperez@ipn.mx', '5552233445', 'Lago Erne', '212', '3', 'Pensil Norte', 'Miguel Hidalgo', 11430),
(18, 'Laura', 'Gómez', 'Díaz', 'GODL880613H56', 'laura.gomez@example.com', 'lgomez@ipn.mx', '5553344556', 'Lago Muritz', '95', '4', 'Pensil Sur', 'Miguel Hidalgo', 11430),
(18, 'Miguel', 'Sánchez', 'Ortiz', 'SAOM890724I67', 'miguel.sanchez@example.com', 'msanchez@ipn.mx', '5554455667', 'Lago Mayor', '33', '5', 'Lago Norte', 'Miguel Hidalgo', 11410);

-- Academia: Tecnologías Ferroviarias (19)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(19, 'Eva', 'Martínez', 'Reyes', 'MARE900805J78', 'eva.martinez@example.com', 'emartinez@ipn.mx', '5555566778', 'Lago Ness', '118', '6', 'Lago Sur', 'Miguel Hidalgo', 11410),
(19, 'Fernando', 'López', 'Juárez', 'LOJF910916K89', 'fernando.lopez@example.com', 'flopez@ipn.mx', '5556677889', 'Lago Ginebra', '47', '1', '5 de Mayo', 'Miguel Hidalgo', 11450),
(19, 'Cristina', 'Hernández', 'Campos', 'HECR921027L90', 'cristina.hernandez@example.com', 'chernandez@ipn.mx', '5557788990', 'Lago Constanza', '90', '2', 'Modelo Pensil', 'Miguel Hidalgo', 11440),
(19, 'David', 'García', 'Fuentes', 'GAFD931108M01', 'david.garcia@example.com', 'dgarcia@ipn.mx', '5558899001', 'Lago Bolsena', '155', '3', 'Legaria', 'Miguel Hidalgo', 11420),
(19, 'Alicia', 'Ramírez', 'Soto', 'RASA941219N12', 'alicia.ramirez@example.com', 'aramirez@ipn.mx', '5559900112', 'Lago Valencia', '63', '4', 'Mariano Escobedo', 'Miguel Hidalgo', 11310);

-- Academia: Laboratorios de Procesos de Manufactura (20)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(20, 'Víctor', 'Morales', 'Luna', 'MOLV850310O23', 'victor.morales@example.com', 'vmorales@ipn.mx', '5550011223', 'Golfo de Adén', '27', '1', 'Argentina Antigua', 'Miguel Hidalgo', 11270),
(20, 'Sofía', 'Cruz', 'Mendoza', 'CRSM860421P34', 'sofia.cruz@example.com', 'scruz@ipn.mx', '5551122334', 'Golfo de California', '84', '2', 'Argentina Poniente', 'Miguel Hidalgo', 11230),
(20, 'Hugo', 'Torres', 'Vargas', 'TOVH870502Q45', 'hugo.torres@example.com', 'htorres@ipn.mx', '5552233445', 'Golfo de México', '112', '3', 'Santo Tomás', 'Miguel Hidalgo', 11340),
(20, 'Patricia', 'Ríos', 'Salinas', 'RISP880613R56', 'patricia.rios@example.com', 'prios@ipn.mx', '5553344556', 'Golfo de Tehuantepec', '58', '4', 'Santo Tomás', 'Miguel Hidalgo', 11340),
(20, 'Javier', 'López', 'Gómez', 'LOGJ890724S67', 'javier.lopez@example.com', 'jlopez@ipn.mx', '5554455667', 'Golfo de Campeche', '190', '5', 'Agricultura', 'Miguel Hidalgo', 11360);

-- Academia: Laboratorios de Control de Calidad (21)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(21, 'Gloria', 'Fuentes', 'Díaz', 'FUDG900805T78', 'gloria.fuentes@example.com', 'gfuentes@ipn.mx', '5555566778', 'Mar Báltico', '225', '6', 'Nextitla', 'Miguel Hidalgo', 11420),
(21, 'Andrés', 'Hernández', 'Reyes', 'HERA910916U89', 'andres.hernandez@example.com', 'ahernandez@ipn.mx', '5556677889', 'Mar del Norte', '78', '1', 'Popotla', 'Miguel Hidalgo', 11400),
(21, 'Carmen', 'García', 'Campos', 'GACC921027V90', 'carmen.garcia@example.com', 'cgarcia@ipn.mx', '5557788990', 'Mar Rojo', '142', '2', 'Tacuba', 'Miguel Hidalgo', 11410),
(21, 'Luis', 'Ramírez', 'Soto', 'RASL931108W01', 'luis.ramirez@example.com', 'lramirez@ipn.mx', '5558899001', 'Mar Negro', '65', '3', 'Tacubaya', 'Miguel Hidalgo', 11870),
(21, 'Ana', 'Vargas', 'López', 'VALL941219X12', 'ana.vargas@example.com', 'avargas@ipn.mx', '5559900112', 'Mar Caspio', '189', '4', 'Reforma Pensil', 'Miguel Hidalgo', 11430);

-- Academia: Laboratorios de Ingeniería de Métodos (22)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(22, 'Raúl', 'Sánchez', 'Mendoza', 'SAMR850310Y23', 'raul.sanchez@example.com', 'rsanchez@ipn.mx', '5550011223', 'Mar Egeo', '55', '1', 'San Diego Ocoyoacac', 'Miguel Hidalgo', 11460),
(22, 'Isabel', 'Cruz', 'Torres', 'CRTI860421Z34', 'isabel.cruz@example.com', 'icruz@ipn.mx', '5551122334', 'Mar Amarillo', '120', '2', 'Lomas de Sotelo', 'Miguel Hidalgo', 11200),
(22, 'Pedro', 'Lara', 'Fuentes', 'LAFP870502A45', 'pedro.lara@example.com', 'plara@ipn.mx', '5552233445', 'Mar de Java', '88', '3', '10 de Abril', 'Miguel Hidalgo', 11250),
(22, 'María', 'Ríos', 'González', 'RIGM880613B56', 'maria.rios@example.com', 'mrios@ipn.mx', '5553344556', 'Mar de las Antillas', '210', '4', 'Lomas de Chapultepec', 'Miguel Hidalgo', 11000),
(22, 'Carlos', 'Ocampo', 'Vargas', 'OCVC890724C67', 'carlos.ocampo@example.com', 'cOcampo@ipn.mx', '5554455667', 'Mar Arábigo', '45', '5', 'Bosque de Chapultepec', 'Miguel Hidalgo', 11100);

-- Academia: Laboratorios de Sistemas Automotrices (23)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(23, 'Gabriela', 'Soto', 'Ríos', 'SORG900805D78', 'gabriela.soto@example.com', 'gsoto@ipn.mx', '5555566778', 'Prolongación Carpio', '471', '6', 'Plutarco Elías Calles', 'Miguel Hidalgo', 11350),
(23, 'Roberto', 'Mendoza', 'Cruz', 'MECR910916E89', 'roberto.mendoza@example.com', 'rmendoza@ipn.mx', '5556677889', 'Plan de Ayala', '620', '1', 'Santo Tomás', 'Miguel Hidalgo', 11340),
(23, 'Teresa', 'Fuentes', 'Lara', 'FULT921027F90', 'teresa.fuentes@example.com', 'tfuentes@ipn.mx', '5557788990', 'Manuel Carpio', '435', '2', 'Santa María la Ribera', 'Cuauhtémoc', 06400),
(23, 'Jorge', 'Vargas', 'Gómez', 'VAGG931108G01', 'jorge.vargas@example.com', 'jvargas@ipn.mx', '5558899001', 'Salvador Díaz Mirón', '388', '3', 'Agricultura', 'Miguel Hidalgo', 11360),
(23, 'Silvia', 'López', 'Hernández', 'LOHS941219H12', 'silvia.lopez@example.com', 'slopez@ipn.mx', '5559900112', 'Nopaltzin', '152', '4', 'Tlatilco', 'Azcapotzalco', 02860);

-- Academia: Laboratorios de Automatización y Robótica (24)
INSERT INTO Docente (id_academia, nom_doc, ap_doc, am_doc, rfc, email_p_doc, email_i_doc, tel_doc, calle, no_ext, no_int, colonia, delegacion, cp) VALUES
(24, 'Alejandro', 'Reyes', 'Campos', 'RECA850310I23', 'alejandro.reyes@example.com', 'areyes@ipn.mx', '5550011223', 'Avenida Santa Ana', '1000', '1', 'San Francisco Culhuacán', 'Coyoacán', 04260),
(24, 'Beatriz', 'Torres', 'Salinas', 'TOSB860421J34', 'beatriz.torres@example.com', 'btorres@ipn.mx', '5551122334', 'Calzada de la Virgen', '1500', '2', 'CTM Culhuacán', 'Coyoacán', 04480),
(24, 'César', 'Mendoza', 'Vargas', 'MEVC870502K45', 'cesar.mendoza@example.com', 'cmendoza@ipn.mx', '5552233445', 'Canal Nacional', '2000', '3', 'Campestre Churubusco', 'Coyoacán', 04200),
(24, 'Diana', 'Lara', 'Fuentes', 'LAFD880613L56', 'diana.lara@example.com', 'dlara@ipn.mx', '5553344556', 'Eje 3 Oriente', '2500', '4', 'Ex-Ejido de San Francisco Culhuacán', 'Coyoacán', 04420),
(24, 'Ernesto', 'Ocampo', 'Ponce', 'OAPE890724M67', 'ernesto.ocampo@example.com', 'eocampo@ipn.mx', '5554455667', 'Calzada Taxqueña', '1800', '5', 'Paseos de Taxqueña', 'Coyoacán', 04250);
