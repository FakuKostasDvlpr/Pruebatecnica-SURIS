import { useState, useEffect } from 'react';
import api from '../services/api';
import { usePedidos } from '../Context/PedidoContext';

function CrearPedido() {

    const {items,vendedor} = usePedidos()
 
 

    const enviarPedido = async () => {
        try {
            await api.post('/Pedido', {vendedorId:vendedor.id,detalles:items});
            alert('Pedido creado con éxito');
        } catch (error) {
            console.error('Error al crear el pedido:', error);
            alert('Error al crear el pedido');
        }
    };

    return (
        <>
        <form className="container">
            <h1>Revisión</h1>
            
            <p> {vendedor && `Vendedor:${vendedor.descripcion}` }</p>

            <ul>
                {items.length > 0 && items.map((item) => <li key={item.id}>{item.descripcion}</li>)}
            </ul>
            
                <button type='button' className="btn btn-primary mt-3" onClick={enviarPedido}>
                    Crear Pedido
                </button>
            </form>
        
        </>
    );
}

export default CrearPedido;
