import { useQuery } from '@tanstack/react-query'
import { getUserById } from '../apis/apiClient'

export function useGetUserById(id: number) {
  return useQuery({
    queryKey: ['user'],
    queryFn: async () => await getUserById(id),
  })
}
