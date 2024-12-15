import { useEffect, useState, useRef } from 'react';
import api from '../services/api';
import { usePedidos } from '../Context/PedidoContext';


function Vendedores() {
    const [vendedores, setVendedores] = useState([]);
    const {setVendedor} = usePedidos()
    const vendedorRef = useRef();
    useEffect(() => {
        const fetchVendedores = async () => {
            try {
                const response = await api.get('/Vendedor');
                setVendedores(response.data);
            } catch (error) {
                console.error('Error al cargar los vendedores:', error);
            }
        };

        fetchVendedores();
    }, []);

    return (
        <div className="container">
            <h1>Vendedores</h1>
            <form>
                <select ref={vendedorRef} onChange={() => setVendedor(vendedores.find((v) => v.id == vendedorRef.current.value)) }>
                <option value="0" disabled>Seleccionar</option>
                {vendedores.map((vendedor) => (
                    <option key={vendedor.id} value={vendedor.id}>
                        {vendedor.descripcion}
                    </option>
                ))}
                </select>
            </form>
        </div>
    );
}

export default Vendedores;
