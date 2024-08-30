import { useMutation, useQueryClient } from '@tanstack/react-query'
import { deleteUser } from '../apis/apiClient'

function useDeleteUser() {
  const client = useQueryClient()
  return useMutation({
    mutationFn: (values: number) => deleteUser(values),
    onSuccess: () => {
      client.invalidateQueries({ queryKey: ['user'] })
    },
  })
}

export default useDeleteUser
