import { ReactNode } from 'react'

function Button(props: {
  onClick?: () => void
  className?: string
  id?: string
  children: ReactNode
}) {
  const { onClick, className = '', children, id = '' } = props
  const defaultClassName = 'bg-customGreen text-white p-3 text-2xl rounded-full'
  return (
    <button
      className={`${defaultClassName} ${className}`}
      id={id}
      onClick={onClick}
    >
      {children}
    </button>
  )
}

export default Button
