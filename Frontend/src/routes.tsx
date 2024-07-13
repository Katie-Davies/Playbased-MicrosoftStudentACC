import { createRoutesFromElements, Route } from 'react-router-dom'
import App from './pages/App'
import Landing from './pages/Landing'
import Favourites from './pages/Favourites'
import Activities from './pages/Activities'
import Layout from './pages/Layout'

// Named export of the routes
export const routes = createRoutesFromElements(
  <>
    <Route path="/" element={<Landing />} />
    <Route element={<Layout />}>
      <Route path="/activities" element={<Activities />} />
      <Route path="/favourites" element={<Favourites />} />
    </Route>
  </>
)

// Default export of the named routes
export default routes
