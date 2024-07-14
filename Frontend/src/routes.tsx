import { createRoutesFromElements, Route } from 'react-router-dom'

import Landing from './pages/Landing'
import Favourites from './pages/Favourites'
import Activities from './pages/Activities'
import Layout from './pages/Layout'
import ActivityInformation from './pages/ActivityInformation'

// Named export of the routes
export const routes = createRoutesFromElements(
  <>
    <Route path="/" element={<Landing />} />
    <Route element={<Layout />}>
      <Route path="/activities" element={<Activities />} />
      <Route path="/activities/:id" element={<ActivityInformation />} />
      <Route path="/favourites" element={<Favourites />} />
    </Route>
  </>
)

// Default export of the named routes
export default routes
