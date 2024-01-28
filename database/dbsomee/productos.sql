create table productosropa(
	idproducto int primary key identity,
	rutaimagen varchar(100) null,
    nombreimagen varchar(100) null,
	codigo varchar(50) not null,
	nombre varchar(50) not null,
	descripcion varchar(50) not null,
	idcategoria int references categorias(idcategoria) not null,
	idtallaropa int references tallasropa(idtallaropa) not null,
	stock int default 0 not null,
	colores varchar(40) not null,
	numcaja varchar(50) not null,
	precioventa decimal(10,2) default 0 not null,
	temporada varchar(60) not null,
	descuento int default 0,
	total decimal(10,2) default 0 not null,
	ubicacion varchar(50) NULL,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go

insert into productosropa (codigo, nombre, descripcion, idcategoria, idtallaropa, stock, colores, numcaja, precioventa, temporada, descuento, total, ubicacion) values
/*tienda*/
('prueba', 'romina', 'vestido', '3', '1', '7', 'marino', '001', '62', 'Invierno - 2023', '0', '434', 'Tienda'),
/*almacen*/
('RTKDR19S233', 'romina', 'vestido', '3', '1', '7', 'marino', '001', '62', 'Invierno - 2023', '0', '434', 'Almacen'),
('RTKDR19M233', 'romina', 'vestido', '3', '2', '7', 'marino', '001', '62', 'Invierno - 2023', '0', '434', 'Almacen'),
('RTKDR19L233', 'romina', 'vestido', '3', '3', '2', 'marino', '001', '62', 'Invierno - 2023', '0', '124', 'Almacen'),
('RTKDL1S233', 'layka', 'polo', '3', '1', '11', 'blanco', '061', '55', 'Invierno - 2023', '0', '605', 'Almacen'),
('RTKDL1M233', 'layka', 'polo', '3', '2', '16', 'blanco', '061', '55', 'Invierno - 2023', '0', '880', 'Almacen'),
('RTKDL1L233', 'layka', 'polo', '3', '3', '3', 'blanco', '061', '55', 'Invierno - 2023', '0', '330', 'Almacen'),
('RTKDL10S233', 'layka', 'polo', '3', '1', '16', 'negro', '061', '55', 'Invierno - 2023', '0', '880', 'Almacen'),
('RTKDL10M233', 'layka', 'polo', '3', '2', '12', 'negro', '061', '55', 'Invierno - 2023', '0', '660', 'Almacen'),
('RTKDL10L233', 'layka', 'polo', '3', '3', '5', 'negro', '061', '55', 'Invierno - 2023', '0', '275', 'Almacen'),
('VESH30S23', 'hila', 'vestido', '3', '1', '18', 'vino', '037', '29.9', 'Verano - 2023', '0', '538.2', 'Almacen'),
('VESH30M23', 'hila', 'vestido', '3', '2', '15', 'vino', '037', '29.9', 'Verano - 2023', '0', '448.5', 'Almacen'),
('VESH30L23', 'hila', 'vestido', '3', '3', '4', 'vino', '037', '29.9', 'Verano - 2023', '0', '119.6', 'Almacen'),
('BLUD4M23', 'dayana', 'bluza', '3', '2', '9', 'rosa', '017', '24.9', 'Verano - 2023', '0', '224.1', 'Almacen'),
('BLUD4L23', 'dayana', 'bluza', '3', '3', '21', 'rosa', '017', '24.9', 'Verano - 2023', '0', '522.9', 'Almacen'),
('BLUD80S23', 'dayana', 'bluza', '3', '1', '5', 'rojo', '017', '24.9', 'Verano - 2023', '0', '124.5', 'Almacen'),
('BLUD80M23', 'dayana', 'bluza', '3', '2', '2', 'rojo', '017', '24.9', 'Verano - 2023', '0', '49.8', 'Almacen'),
('BLUD92S23', 'dayana', 'bluza', '3', '1', '3', 'turqueza', '017', '24.9', 'Verano - 2023', '0', '74.7', 'Almacen'),
('BLUD92M23', 'dayana', 'bluza', '3', '2', '8', 'turqueza', '017', '24.9', 'Verano - 2023', '0', '199.2', 'Almacen'),
('RTKDF2S233', 'franci', 'vestido', '3', '1', '14', 'floreado(azul)', '036', '79', 'Invierno - 2023', '0', '1106', 'Almacen'),
('RTKDF2M233', 'franci', 'vestido', '3', '2', '14', 'floreado (azul)', '036', '79', 'Invierno - 2023', '0', '1106', 'Almacen'),
('RTKDF2L233', 'franci', 'vestido', '3', '3', '1', 'floreado (azul)', '036', '79', 'Invierno - 2023', '0', '79', 'Almacen'),
('RTKDQ2S233', 'queen', 'bluza', '3', '1', '13', 'azul', '0', '45', 'Invierno - 2023', '0', '585', 'Almacen'),
('RTKDQ2M233', 'queen', 'bluza', '3', '2', '10', 'azul', '0', '45', 'Invierno - 2023', '0', '450', 'Almacen'),
('RTKDQ2L233', 'queen', 'bluza', '3', '3', '6', 'azul', '0', '45', 'Invierno - 2023', '0', '270', 'Almacen'),
('RTKDQ10S233', 'queen', 'bluza', '3', '1', '12', 'negro', '0', '45', 'Invierno - 2023', '0', '540', 'Almacen'),
('RTKDQ10M233', 'queen', 'bluza', '3', '2', '11', 'negro', '0', '45', 'Invierno - 2023', '0', '495', 'Almacen'),
('RTKDQ10L233', 'queen', 'bluza', '3', '3', '2', 'negro', '0', '45', 'Invierno - 2023', '0', '90', 'Almacen'),
('RTKDZ34S233', 'zoila', 'bluza', '3', '1', '10', 'camello', '0', '29.9', 'Invierno - 2023', '0', '299', 'Almacen'),
('RTKDZ34M233', 'zoila', 'bluza', '3', '2', '15', 'camello', '0', '29.9', 'Invierno - 2023', '0', '448.5', 'Almacen'),
('RTKDZ34L233', 'zoila', 'blusa', '3', '3', '3', 'camello', '0', '29.9', 'Invierno - 2023', '0', '89.7', 'Almacen'),
('RTKDZ19S233', 'zoila', 'bluza', '3', '1', '8', 'marino', '0', '29.9', 'Invierno - 2023', '0', '239.2', 'Almacen'),
('RTKDZ19M233', 'zoila', 'bluza', '3', '2', '8', 'marino', '0', '29.9', 'Invierno - 2023', '0', '239.2', 'Almacen'),
('RTKDZ19L233', 'zoila', 'bluza', '3', '3', '3', 'marino', '0', '29.9', 'Verano - 2023', '0', '89.7', 'Almacen'),
('RTKDU10S233', 'ursula', 'bluza', '3', '1', '10', 'negro', '0', '39.9', 'Verano - 2023', '0', '399', 'Almacen'),
('RTKDU10M233', 'ursula', 'bluza', '3', '2', '6', 'negro', '0', '39.9', 'Verano - 2023', '0', '239.4', 'Almacen'),
('RTKDU10L233', 'ursula', 'bluza', '3', '3', '11', 'negro', '0', '39.9', 'Verano - 2023', '0', '438.9', 'Almacen'),
('RTKDI2S233', 'iris', 'bluza', '3', '1', '10', 'azul', '0', '39.9', 'Verano - 2023', '0', '399', 'Almacen'),
('RTKDI2M233', 'iris', 'bluza', '3', '2', '2', 'azul', '0', '39.9', 'Verano - 2023', '0', '79.8', 'Almacen'),
('RTKDI2L233', 'iris', 'bluza', '3', '3', '3', 'azul', '0', '39.9', 'Verano - 2023', '0', '119.7', 'Almacen'),
('RTKDV20S233', 'vienna', 'bluza', '3', '1', '18', 'rojo a rayas', '0', '39.9', 'Verano - 2023', '0', '718.2', 'Almacen'),
('RTKDV20M233', 'vienna', 'bluza', '3', '2', '14', 'rojo a rayas', '0', '39.9', 'Verano - 2023', '0', '558.6', 'Almacen'),
('RTKDV20L233', 'vienna', 'bluza', '3', '3', '12', 'rojo a rayas', '0', '39.9', 'Verano - 2023', '0', '478.8', 'Almacen'),
('RTKDS21S233', 'shari', 'bluza', '3', '1', '14', 'mostaza', '0', '35', 'Verano - 2023', '0', '490', 'Almacen'),
('RTKDS21M233', 'shari', 'bluza', '3', '2', '17', 'mostaza', '0', '35', 'Verano - 2023', '0', '595', 'Almacen'),
('RTKDS21L233', 'shari', 'bluza', '3', '3', '6', 'mostaza', '0', '35', 'Verano - 2023', '0', '210', 'Almacen'),
('RTKDS2S233', 'shari', 'bluza', '3', '1', '18', 'azul', '0', '35', 'Verano - 2023', '0', '630', 'Almacen'),
('RTKDS2M233', 'shari', 'bluza', '3', '2', '16', 'azul', '0', '35', 'Verano - 2023', '0', '560', 'Almacen'),
('RTKDS2L233', 'shari', 'bluza', '3', '3', '7', 'azul', '0', '35', 'Verano - 2023', '0', '245', 'Almacen'),
('RTKDM18S233', 'mabel', 'polo', '3', '1', '12', 'naranja', '0', '39', 'Verano - 2023', '0', '468', 'Almacen'),
('RTKDM18M233', 'mabel', 'polo', '3', '2', '9', 'naranja', '0', '39', 'Verano - 2023', '0', '351', 'Almacen'),
('RTKDM18L233', 'mabel', 'polo', '3', '3', '12', 'naranja', '0', '39', 'Verano - 2023', '0', '468', 'Almacen'),
('RTKDM19S233', 'mabel', 'polo', '3', '1', '11', 'marino', '0', '39', 'Verano - 2023', '0', '429', 'Almacen'),
('RTKDM19M233', 'mabel', 'polo', '3', '2', '10', 'marino', '0', '39', 'Verano - 2023', '0', '390', 'Almacen'),
('RTKDM19L233', 'mabel', 'polo', '3', '3', '12', 'marino', '0', '39', 'Verano - 2023', '0', '468', 'Almacen'),
('RTKDX10S233', 'xiomara', 'bluza', '3', '1', '2', 'negro / blanco', '0', '34.9', 'Verano - 2023', '0', '69.8', 'Almacen'),
('RTKDX10M233', 'xiomara', 'bluza', '3', '2', '1', 'negro / blanco', '0', '34.9', 'Verano - 2023', '0', '34.9', 'Almacen'),
('RTKDX10L233', 'xiomara', 'bluza', '3', '3', '4', 'negro / blanco', '0', '34.9', 'Verano - 2023', '0', '139.6', 'Almacen'),
('RTKDX13S233', 'xiomara', 'bluza', '3', '1', '6', 'rosado / blanco', '0', '34.9', 'Verano - 2023', '0', '209.4', 'Almacen'),
('RTKDX13M233', 'xiomara', 'bluza', '3', '2', '8', 'rosado / blanco', '0', '34.9', 'Verano - 2023', '0', '279.2', 'Almacen'),
('RTKDX13L233', 'xiomara', 'bluza', '3', '3', '2', 'rosado / blanco', '0', '34.9', 'Verano - 2023', '0', '69.8', 'Almacen'),
('RTKDP19XS233', 'paty', 'polo', '3', '5', '2', 'marino / plomo', '0', '39.9', 'Verano - 2023', '0', '79.8', 'Almacen'),
('RTKDP19S233', 'paty', 'polo', '3', '1', '4', 'marino / plomo', '0', '39.9', 'Verano - 2023', '0', '159.6', 'Almacen'),
('RTKDP19M233', 'paty', 'polo', '3', '2', '4', 'marino / plomo', '0', '39.9', 'Verano - 2023', '0', '159.6', 'Almacen'),
('RTKDN20S233', 'nayda', 'bluza', '3', '1', '22', 'rojo', '0', '42.9', 'Verano - 2023', '0', '943.8', 'Almacen'),
('RTKDN20M233', 'nayda', 'bluza', '3', '2', '13', 'rojo', '0', '42.9', 'Verano - 2023', '0', '557.7', 'Almacen'),
('RTKDN20L233', 'nayda', 'bluza', '3', '3', '6', 'rojo', '0', '42.9', 'Verano - 2023', '0', '257.4', 'Almacen'),
('RTKDG1S233', 'gimena', 'bluza', '3', '1', '4', 'blanco / negro', '0', '44.9', 'Verano - 2023', '0', '179.6', 'Almacen'),
('RTKDG1M233', 'gimena', 'bluza', '3', '2', '7', 'blanco / negro', '0', '44.9', 'Verano - 2023', '0', '314.3', 'Almacen'),
('RTKDG1L233', 'gimena', 'bluza', '3', '3', '1', 'blanco / negro', '0', '44.9', 'Verano - 2023', '0', '44.9', 'Almacen'),
('RTKDY9S233', 'yadira', 'bluza', '3', '1', '17', 'guinda', '0', '34.9', 'Verano - 2023', '0', '593.3', 'Almacen'),
('RTKDY9M233', 'yadira', 'bluza', '3', '2', '16', 'guinda', '0', '44.9', 'Verano - 2023', '0', '718.4', 'Almacen'),
('RTKDY9L233', 'yadira', 'bluza', '3', '3', '1', 'blanco / negro', '0', '44.9', 'Verano - 2023', '0', '44.9', 'Almacen'),
('RTKDY28S233', 'yadira', 'bluza', '3', '1', '12', 'melon', '0', '44.9', 'Verano - 2023', '0', '538.8', 'Almacen'),
('RTKDY28M233', 'yadira', 'bluza', '3', '2', '9', 'melon', '0', '44.9', 'Invierno - 2023', '0', '404.1', 'Almacen'),
('RTKDY28L233', 'yadira', 'bluza', '3', '3', '1', 'melon', '0', '44.9', 'Invierno - 2023', '0', '44.9', 'Almacen'),
('RTKDF36S233', 'fabianne', 'vestido', '3', '1', '6', 'navy / rojo', '0', '120', 'Invierno - 2023', '0', '720', 'Almacen'),
('RTKDF36M233', 'fabianne', 'vestido', '3', '2', '22', 'navy / rojo', '0', '120', 'Invierno - 2023', '0', '2640', 'Almacen'),
('RTKDF36L233', 'fabianne', 'vestido', '3', '3', '22', 'navy / rojo', '0', '120', 'Invierno - 2023', '0', '2640', 'Almacen'),
('RTKDF36XL233', 'fabianne', 'vestido', '3', '4', '6', 'navy / rojo', '0', '120', 'Invierno - 2023', '0', '720', 'Almacen'),
('RTKDF20S233', 'fabianne', 'vestido', '3', '1', '9', 'rojo / navy', '0', '120', 'Invierno - 2023', '0', '1080', 'Almacen'),
('RTKDF20M233', 'fabianne', 'vestido', '3', '2', '20', 'rojo / navy', '0', '120', 'Invierno - 2023', '0', '2400', 'Almacen'),
('RTKDF20L233', 'fabianne', 'vestido', '3', '3', '21', 'rojo / navy', '0', '120', 'Invierno - 2023', '0', '2520', 'Almacen'),
('RTKDF20XL233', 'fabianne', 'vestido', '3', '4', '10', 'rojo / navy', '0', '120', 'Invierno - 2023', '0', '1200', 'Almacen'),
('VESC10S23', 'colette', 'vestido', '3', '1', '9', 'negro', '0', '65', 'Primavera - 2023', '0', '585', 'Almacen'),
('VESC10M23', 'colette', 'vestido', '3', '2', '19', 'negro', '0', '65', 'Primavera - 2023', '0', '1235', 'Almacen'),
('VESC10L23', 'colette', 'vestido', '3', '3', '18', 'negro', '0', '65', 'Primavera - 2023', '0', '1170', 'Almacen'),
('VESC10XL23', 'colette', 'vestido', '3', '4', '9', 'negro', '0', '65', 'Primavera - 2023', '0', '585', 'Almacen'),
('VESC93S23', 'colette', 'vestido', '3', '1', '9', 'rosa', '0', '65', 'Primavera - 2023', '0', '585', 'Almacen'),
('VESC93M23', 'colette', 'vestido', '3', '2', '19', 'rosa', '0', '65', 'Primavera - 2023', '0', '1235', 'Almacen'),
('VESC93L23', 'colette', 'vestido', '3', '3', '19', 'rosa', '0', '65', 'Primavera - 2023', '0', '1235', 'Almacen'),
('VESC93XL23', 'colette', 'vestido', '3', '4', '9', 'rosa', '0', '65', 'Primavera - 2023', '0', '585', 'Almacen'),
('VESC79S23', 'colette', 'vestido', '3', '1', '8', 'verde oliva', '0', '65', 'Primavera - 2023', '0', '520', 'Almacen'),
('VESC79M23', 'colette', 'vestido', '3', '2', '19', 'verde oliva', '0', '65', 'Primavera - 2023', '0', '1235', 'Almacen'),
('VESC79L23', 'colette', 'vestido', '3', '3', '19', 'verde oliva', '0', '65', 'Primavera - 2023', '0', '1235', 'Almacen'),
('VESC79XL23', 'colette', 'vestido', '3', '4', '9', 'verde oliva', '0', '65', 'Primavera - 2023', '0', '585', 'Almacen'),
('RTKDD40L2332', 'donna', 'polo murcielago', '3', '3', '21', 'ladrillo', '0', '44.9', 'Invierno - 2023', '0', '942.9', 'Almacen'),
('RTKDD40XL2332', 'donna', 'polo murcielago', '3', '4', '7', 'ladrillo', '0', '44.9', 'Invierno - 2023', '0', '314.3', 'Almacen'),
('RTKDD3S2332', 'donna', 'polo murcielago', '3', '1', '2', 'verde claro', '0', '44.9', 'Invierno - 2023', '0', '89.8', 'Almacen'),
('RTKDD3M2332', 'donna', 'polo murcielago', '3', '2', '2', 'verde claro', '0', '44.9', 'Invierno - 2023', '0', '89.8', 'Almacen'),
('RTKDD27S2332', 'donna', 'polo murcielago', '3', '1', '18', 'verde oliva', '0', '44.9', 'Invierno - 2023', '0', '808.2', 'Almacen'),
('RTKDD27M2332', 'donna', 'polo murcielago', '3', '2', '20', 'verde oliva', '0', '44.9', 'Invierno - 2023', '0', '898', 'Almacen'),
('RTKDD27L2332', 'donna', 'polo murcielago', '3', '3', '9', 'verde oliva', '0', '44.9', 'Invierno - 2023', '0', '404.1', 'Almacen'),
('RTKDD27XL2332', 'donna', 'polo murcielago', '3', '4', '9', 'verde oliva', '0', '44.9', 'Invierno - 2023', '0', '404.1', 'Almacen'),
('RTKDD10S2332', 'donna', 'polo murcielago', '3', '1', '13', 'negro', '0', '44.9', 'Invierno - 2023', '0', '583.7', 'Almacen'),
('RTKDD10M2332', 'donna', 'polo murcielago', '3', '2', '20', 'negro', '0', '44.9', 'Invierno - 2023', '0', '898', 'Almacen'),
('RTKDD10L2332', 'donna', 'polo murcielago', '3', '3', '18', 'negro', '0', '44.9', 'Invierno - 2023', '0', '808.2', 'Almacen'),
('RTKDD10XL2332', 'donna', 'polo murcielago', '3', '4', '5', 'negro', '0', '44.9', 'Invierno - 2023', '0', '224.5', 'Almacen'),
('RTKDD23S2332', 'donna', 'polo murcielago', '3', '1', '11', 'turqueza claro', '0', '44.9', 'Invierno - 2023', '0', '493.9', 'Almacen'),
('RTKDD23M2332', 'donna', 'polo murcielago', '3', '2', '12', 'turqueza claro', '0', '44.9', 'Invierno - 2023', '0', '538.8', 'Almacen'),
('RTKDD23L2332', 'donna', 'polo murcielago', '3', '3', '4', 'turqueza claro', '0', '44.9', 'Invierno - 2023', '0', '179.6', 'Almacen'),
('RTKDD23XL2332', 'donna', 'polo murcielago', '3', '4', '7', 'turqueza claro', '0', '44.9', 'Invierno - 2023', '0', '314.3', 'Almacen'),
('RTKDD6S2332', 'donna', 'polo murcielago', '3', '1', '16', 'marron', '0', '44.9', 'Invierno - 2023', '0', '718.4', 'Almacen'),
('RTKDD6M2332', 'donna', 'polo murcielago', '3', '2', '17', 'marron', '0', '44.9', 'Invierno - 2023', '0', '763.3', 'Almacen'),
('RTKDD6L2332', 'donna', 'polo murcielago', '3', '3', '4', 'marron', '0', '44.9', 'Invierno - 2023', '0', '179.6', 'Almacen'),
('RTKDD6XL2332', 'donna', 'polo murcielago', '3', '4', '6', 'marron', '0', '44.9', 'Invierno - 2023', '0', '269.4', 'Almacen'),
('RTKDD17S2332', 'donna', 'polo murcielago', '3', '1', '1', 'celeste ht', '0', '44.9', 'Invierno - 2023', '0', '44.9', 'Almacen'),
('RTKDD17M2332', 'donna', 'polo murcielago', '3', '2', '8', 'celeste ht', '0', '44.9', 'Invierno - 2023', '0', '359.2', 'Almacen'),
('RTKDD17XXL2332', 'donna', 'polo murcielago', '3', '6', '2', 'celeste ht', '0', '44.9', 'Invierno - 2023', '0', '89.8', 'Almacen'),
('RTKDD20S2332', 'donna', 'polo murcielago', '3', '1', '2', 'rojo ht', '0', '44.9', 'Invierno - 2023', '0', '89.8', 'Almacen'),
('RTKDD20M2332', 'donna', 'polo murcielago', '3', '2', '16', 'rojo ht', '0', '44.9', 'Invierno - 2023', '0', '718.4', 'Almacen'),
('POLDV1S23', 'vari', 'polo cruzado', '3', '1', '8', 'blanco', '0', '39.9', 'Invierno - 2023', '0', '319.2', 'Almacen'),
('POLDV1M23', 'vari', 'polo cruzado', '3', '2', '11', 'blanco', '0', '39.9', 'Invierno - 2023', '0', '438.9', 'Almacen'),
('POLDV1L23', 'vari', 'polo cruzado', '3', '3', '7', 'blanco', '0', '39.9', 'Invierno - 2023', '0', '279.3', 'Almacen'),
('POLDV1XL23', 'vari', 'polo cruzado', '3', '4', '7', 'blanco', '0', '39.9', 'Invierno - 2023', '0', '279.3', 'Almacen'),
('POLDV9S23', 'vari', 'polo cruzado', '3', '1', '9', 'marron', '0', '39.9', 'Invierno - 2023', '0', '359.1', 'Almacen'),
('POLDV9L23', 'vari', 'polo cruzado', '3', '3', '7', 'marron', '0', '39.9', 'Invierno - 2023', '0', '279.3', 'Almacen'),
('POLDV9XL23', 'vari', 'polo cruzado', '3', '4', '7', 'marron', '0', '39.9', 'Invierno - 2023', '0', '279.3', 'Almacen'),
('POLDV27S23', 'vari', 'polo cruzado', '3', '1', '10', 'verde oliva', '0', '39.9', 'Invierno - 2023', '0', '399', 'Almacen'),
('POLDV27M23', 'vari', 'polo cruzado', '3', '2', '11', 'verde oliva', '0', '39.9', 'Invierno - 2023', '0', '438.9', 'Almacen'),
('POLDV27L23', 'vari', 'polo cruzado', '3', '3', '7', 'verde oliva', '0', '39.9', 'Invierno - 2023', '0', '279.3', 'Almacen'),
('POLDV27XL23', 'vari', 'polo cruzado', '3', '4', '7', 'verde oliva', '0', '39.9', 'Invierno - 2023', '0', '279.3', 'Almacen'),
('CAF10S23', 'malu (cafarena)', 'pia', '3', '1', '19', 'negro', '0', '45', 'Invierno - 2023', '0', '855', 'Almacen'),
('CAF10M23', 'malu (cafarena)', 'pia', '3', '2', '38', 'negro', '0', '45', 'Invierno - 2023', '0', '1710', 'Almacen'),
('CAF10L23', 'malu (cafarena)', 'pia', '3', '3', '35', 'negro', '0', '45', 'Invierno - 2023', '0', '1575', 'Almacen'),
('CAF10XL23', 'malu (cafarena)', 'pia', '3', '4', '19', 'negro', '0', '45', 'Invierno - 2023', '0', '855', 'Almacen'),
('CAF3S23', 'malu (cafarena)', 'pia', '3', '1', '9', 'verde oliva', '0', '45', 'Invierno - 2023', '0', '405', 'Almacen'),
('CAF3M23', 'malu (cafarena)', 'pia', '3', '2', '19', 'verde oliva', '0', '45', 'Invierno - 2023', '0', '855', 'Almacen'),
('CAF3L23', 'malu (cafarena)', 'pia', '3', '3', '18', 'verde oliva', '0', '45', 'Invierno - 2023', '0', '810', 'Almacen'),
('CAF3XL23', 'malu (cafarena)', 'pia', '3', '4', '8', 'verde oliva', '0', '45', 'Invierno - 2023', '0', '360', 'Almacen'),
('RTKDZ3S233', 'zelda', 'enterizo', '2', '1', '14', 'verde print', '0', '29.9', 'Verano - 2023', '0', '418.6', 'Almacen'),
('RTKDZ3M233', 'zelda', 'enterizo', '2', '2', '16', 'verde print', '0', '29.9', 'Primavera - 2023', '0', '478.4', 'Almacen'),
('RTKDZ3L233', 'zelda', 'enterizo', '2', '3', '8', 'verde print', '0', '29.9', 'Primavera - 2023', '0', '239.2', 'Almacen'),
('RTKDJ10S233', 'jandi', 'polo', '2', '1', '5', 'negro', '0', '47', 'Primavera - 2023', '0', '235', 'Almacen'),
('RTKDJ10M233', 'jandi', 'polo', '2', '2', '12', 'negro', '0', '47', 'Primavera - 2023', '0', '564', 'Almacen'),
('RTKDJ10L233', 'jandi', 'polo', '2', '3', '14', 'negro', '0', '47', 'Primavera - 2023', '0', '658', 'Almacen'),
('RTKDJ1S233', 'jandi', 'polo', '2', '1', '9', 'blanco', '0', '47', 'Primavera - 2023', '0', '423', 'Almacen'),
('RTKDJ1M233', 'jandi', 'polo', '2', '2', '6', 'blanco', '0', '47', 'Primavera - 2023', '0', '282', 'Almacen'),
('RTKDJ1L233', 'jandi', 'polo', '2', '3', '15', 'blanco', '0', '48', 'Primavera - 2023', '0', '720', 'Almacen'),
('RTKDJ29S233', 'jandi', 'polo', '2', '1', '5', 'gris', '0', '47', 'Primavera - 2023', '0', '235', 'Almacen'),
('RTKDJ29M233', 'jandi', 'polo', '2', '2', '13', 'gris', '0', '47', 'Primavera - 2023', '0', '611', 'Almacen'),
('RTKDJ29L233', 'jandi', 'polo', '2', '3', '16', 'gris', '0', '47', 'Primavera - 2023', '0', '752', 'Almacen'),
('RTKDK35S233', 'kimn', 'vestido', '2', '1', '5', 'chillipaper', '0', '75', 'Primavera - 2023', '0', '375', 'Almacen'),
('RTKDK35M233', 'kimn', 'vestido', '2', '2', '7', 'chillipaper', '0', '75', 'Primavera - 2023', '0', '525', 'Almacen'),
('RTKDK35L233', 'kimn', 'vestido', '2', '3', '7', 'chillipaper', '0', '75', 'Primavera - 2023', '0', '525', 'Almacen');
go
select * from productosropa
go

select idproducto, codigo, nombre, descripcion, c.idcategoria, c.nombrecategoria, tr.idtallaropa, tr.nombretalla, stock, colores, numcaja, precioventa, temporada, descuento, total, ubicacion, CONVERT(VARCHAR(10), p.fecharegistro, 120)AS fecharegistro_producto from productosropa p
inner join categorias c on c.idcategoria = p.idcategoria
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
where ubicacion = 'Almacen';
go
select idproducto, codigo, nombre, descripcion, c.idcategoria, c.nombrecategoria, tr.idtallaropa, tr.nombretalla, stock, colores, numcaja, precioventa, temporada, descuento, total, ubicacion, CONVERT(VARCHAR(10), p.fecharegistro, 120)AS fecharegistro_producto from productosropa p
inner join categorias c on c.idcategoria = p.idcategoria
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
where ubicacion = 'Tienda';
go

/*procedimiento*/
create procedure spu_registrar_productoropa(
	@codigo varchar(50),
	@nombre varchar(50),
	@descripcion varchar(50),
	@idcategoria int,
	@idtallaropa int,
	@stock int,
	@colores varchar(40),
	@numcaja varchar(50),
	@precioventa decimal(10,2),
	@temporada VARCHAR(60),
    @descuento INT = 0,
    @total DECIMAL(10, 2) = 0,
	@ubicacion varchar(50),
	@resultado int output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 0
	begin
		insert into productosropa(codigo, nombre, descripcion, idcategoria, idtallaropa, stock, colores, numcaja, precioventa, temporada, descuento, total, ubicacion) values
		(@codigo, @nombre, @descripcion, @idcategoria, @idtallaropa, @stock, @colores, @numcaja, @precioventa, @temporada, @descuento, @total, @ubicacion)
		set @resultado = SCOPE_IDENTITY()
	end
end
go

create PROCEDURE spu_editar_productoropa (
    @idproducto INT,
    @codigo VARCHAR(50),
    @nombre VARCHAR(50),
    @descripcion VARCHAR(50),
    @idcategoria INT,
    @idtallaropa INT,
    @stock INT,
    @colores VARCHAR(40),
    @numcaja VARCHAR(50),
    @precioventa DECIMAL(10,2),
    @temporada VARCHAR(60),
    @descuento INT = 0,
    @total DECIMAL(10, 2) = 0,
    @ubicacion VARCHAR(50),
    @resultado INT OUTPUT,
    @mensaje VARCHAR(100) OUTPUT
)
AS
BEGIN
    SET @resultado = 1;
    UPDATE productosropa
    SET
        codigo = @codigo,
        nombre = @nombre,
        descripcion = @descripcion,
        idcategoria = @idcategoria,
        idtallaropa = @idtallaropa,
        stock = @stock,
        colores = @colores,
        numcaja = @numcaja,
        precioventa = @precioventa,
        temporada = @temporada,
        descuento = @descuento,
        total = @total,
        ubicacion = @ubicacion
    WHERE idproducto = @idproducto;
    
    IF @@ROWCOUNT = 0
    BEGIN
        SET @resultado = 0;
        SET @mensaje = 'No se encontró el producto para actualizar.';
    END
END
go

create procedure spu_eliminar_productoropa(
	@idproducto int,
	@respuesta bit output,
	@mensaje varchar(100) output
)
as
begin
    set @respuesta = 0;
    set @mensaje = '';
    declare @pasoreglas bit = 1;

    -- Verificar si el producto está relacionado a una venta en detalle_venta
    if exists (
            select *
            from detalle_venta dv
            inner join productosropa p on p.idproducto = dv.idproducto
            where p.idproducto = @idproducto
        )
    begin
        set @pasoreglas = 0;
        set @respuesta = 0;
        set @mensaje = @mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA';
    end
    if (@pasoreglas = 1)
    begin
        delete from productosropa where idproducto = @idproducto;
        set @respuesta = 1;
    end
end;
go