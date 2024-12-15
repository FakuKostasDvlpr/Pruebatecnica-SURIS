import { useState, useEffect } from 'react';
import api from '../services/api';
const ListaPedidos = () => {
    const [pedidos,setPedidos] = useState([])
    useEffect(() => {
        const getPedidos = async () =>{
            try {
                const {data} = await api.get('/Pedido')
                setPedidos(data.result)
            } catch (error) {
                console.error('Error al cargar los pedidos:', error);
            }
        } 
        getPedidos()
    },[])
    return (
    <ul>
        {pedidos.length > 0 && pedidos.map(p => <li key={p.id}><pre>{JSON.stringify(p,null,2)}</pre></li>)}
    </ul>)
}

export default ListaPedidos