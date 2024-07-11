import { useState } from 'react'

import LogoPng from '../assets/Logo500x500.png'
import LogoJPG from '../assets/Logo500x500.jpg'
import viteLogo from '/vite.svg'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <div>
        <a href="https://vitejs.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={LogoPng} alt="logo png" className="w-24 h-auto" />
          <img src={LogoJPG} className="logo react" alt="logo jpg" />
        </a>
      </div>
      <h1 className="font-sueEllen">Vite + React</h1>
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <p className="font-montserrat">
          Edit <code>src/App.tsx</code> and save to test HMR
        </p>
      </div>
      <p className="text-4xl text-red-600">
        Click on the Vite and React logos to learn more
      </p>
      <h1 className="text-8xl text-red-600 ">Font 1</h1>
    </>
  )
}

export default App
