import { Fragment, useState, useEffect } from 'react';
import api from '../services/api';
import { usePedidos } from '../Context/PedidoContext';

function Articulos() {
    const [articulos, setArticulos] = useState([]);
    const {setItems} = usePedidos()
    useEffect(() => {
        const fetchArticulos = async () => {
            try {
                const response = await api.get('/Articulo');
                setArticulos(response.data);
            } catch (error) {
                console.error('Error al cargar los artículos:', error);
            }
        };

        fetchArticulos();
    }, []);

    const addItem = (id) => 
        setItems((items) => {
            const itemToAdd = articulos.find((articulo) => articulo.id == id);
            if (items.some((item) => item.id === id)) {
                return items;
            }
            return [...items, itemToAdd];
        });
    
        const removeItem = (id) =>  setItems((items) => items.filter((item) => item.id != id))

    return (
        <section className="container">
            <h1>Artículos</h1>
            <form>
                {articulos.map((articulo) => (
                    <Fragment key={articulo.id}>
                        <label htmlFor={articulo.id}>{articulo.descripcion} - ${articulo.precio}</label>
                        <input type="checkbox" value={articulo.id} onChange={(e) => e.target.checked ? addItem(articulo.id) : removeItem(article.id)} />
                    </Fragment>
                ))}
            </form>
        </section>
    );
}

export default Articulos;
